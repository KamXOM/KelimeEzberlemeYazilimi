using System.Security.Cryptography;

namespace KelimeEzberlemeYazilimi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            KelimeDeposu.txtdenOku();//hazır kelimelerin eklenmesi
            KelimeDeposu.resimEkle();//resimlerin ilişkilendirilmesi
            Application.Run(new Anasayfa());
        }
    }
    public static class AccessSettings
    {
        public static bool DisleksiModuAktif { get; set; } = false;
        public static FontFamily DisleksiFont = new FontFamily("OpenDyslexic");
        public static FontFamily NormalFont = new FontFamily("Segoe UI");
        public static bool HighContrastAktif { get; set; } = false;
        public static Color HighContrastBackColor = Color.Black;
        public static Color HighContrastForeColor = Color.White;
        public static Color NormalBackColor = Color.MediumTurquoise; // orijinal arka plan
        public static Color NormalForeColor = SystemColors.ControlText; // orijinal yazı
        public static bool BiggerFontAktif { get; set; } = false;

        // Tüm formlar için orijinal değerleri saklayan global dictionary
        public static Dictionary<Control, (float FontSize, Point Location, Size Size)> OriginalControlValues
            = new Dictionary<Control, (float, Point, Size)>();

        public static void SaveOriginalValues(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                bool wasVisible = c.Visible;

                // Eğer kontrol gizliyse geçici olarak görünür yap
                if (!c.Visible)
                    c.Visible = true;

                if (!OriginalControlValues.ContainsKey(c))
                    OriginalControlValues[c] = (c.Font.Size, c.Location, c.Size);

                if (c.HasChildren)
                    SaveOriginalValues(c);

                // Eski görünürlük durumunu geri yükle
                c.Visible = wasVisible;
            }
        }
        public static void ScaleUI(Control parent, bool aktif)
        {
            float scaleFactor = aktif ? 1.5f : 1f;

            foreach (var kvp in OriginalControlValues)
            {
                Control c = kvp.Key;
                var (origFont, origLoc, origSize) = kvp.Value;

                // Font boyutunu ölçekle
                c.Font = new Font(c.Font.FontFamily, origFont * scaleFactor, c.Font.Style);

                // Konum ve boyutu ölçekle
                c.Location = new Point(
                    (int)(origLoc.X * scaleFactor),
                    (int)(origLoc.Y * scaleFactor)
                );
                c.Size = new Size(
                    (int)(origSize.Width * scaleFactor),
                    (int)(origSize.Height * scaleFactor)
                );
            }

            // Form boyutunu da orijinal değerlere göre ölçekle
            if (parent is Form form)
            {
                if (!OriginalControlValues.ContainsKey(form))
                    OriginalControlValues[form] = (form.Font.Size, form.Location, form.Size);

                var (origFont, origLoc, origSize) = OriginalControlValues[form];
                int newWidth = (int)(origSize.Width * scaleFactor);
                int newHeight = (int)(origSize.Height * scaleFactor);

                // Boyutu uygula
                form.Size = new Size(newWidth, newHeight);

                // Her seferinde ekran merkezine konumlandır
                Rectangle screenBounds = Screen.FromControl(form).WorkingArea;
                form.Left = screenBounds.Left + (screenBounds.Width - form.Width) / 2;
                form.Top = screenBounds.Top + (screenBounds.Height - form.Height) / 2;

            }
            parent.Refresh();
            if (parent is Form form2)
            {
                // Layout motorunu yeniden çalıştır
                form2.PerformLayout();
                form2.Invalidate(); // yeniden çizim
                form2.Update();

                // Bu hile: formun boyutunu 1px değiştirip geri almak (WinForms bug fix)
                form2.Size = new Size(form2.Width + 1, form2.Height);
                form2.Size = new Size(form2.Width - 1, form2.Height);
            }
        }
        public static void AdjustForDyslexia(Control parent, bool aktif)
        {
            float scaleFactor = aktif ? 1.25f : 1f;

            foreach (Control c in parent.Controls)
            {
                if (!OriginalControlValues.ContainsKey(c))
                    continue;

                var (origFont, origLoc, origSize) = OriginalControlValues[c];

                // Fontu büyütme, sadece konum ve boyutla oyna
                c.Location = new Point(
                    (int)(origLoc.X * scaleFactor),
                    (int)(origLoc.Y * scaleFactor)
                );

                c.Size = new Size(
                    (int)(origSize.Width * scaleFactor),
                    (int)(origSize.Height * scaleFactor)
                );

                if (c.HasChildren)
                    AdjustForDyslexia(c, aktif);
            }

            if (parent is Form form)
            {
                if (!OriginalControlValues.ContainsKey(form))
                    OriginalControlValues[form] = (form.Font.Size, form.Location, form.Size);

                var (_, origLoc, origSize) = OriginalControlValues[form];
                form.Size = new Size(
                    (int)(origSize.Width * scaleFactor),
                    (int)(origSize.Height * scaleFactor)
                );

                // Merkezde kalsın
                Rectangle screenBounds = Screen.FromControl(form).WorkingArea;
                form.Left = screenBounds.Left + (screenBounds.Width - form.Width) / 2;
                form.Top = screenBounds.Top + (screenBounds.Height - form.Height) / 2;

                // Layout'u yenile
                form.PerformLayout();
                form.Invalidate();
                form.Update();
            }
        }

        public static void ChangeFontFamily(Control.ControlCollection controls, FontFamily newFamily)
        {
            foreach (Control ctrl in controls)
            {
                try
                {
                    ctrl.Font = new Font(newFamily, ctrl.Font.Size, ctrl.Font.Style);
                }
                catch { /* bazı özel kontrollerde font değişmez, hata bastır */ }

                if (ctrl.HasChildren)
                    ChangeFontFamily(ctrl.Controls, newFamily);
            }
        }
        public static void ApplyHighContrast(Control.ControlCollection controls, bool aktif, Form mainForm)
        {
            // Ana formun arka planını ayarla
            mainForm.BackColor = aktif ? Color.Black : Color.MediumTurquoise;

            foreach (Control ctrl in controls)
            {
                try
                {
                    if (aktif) // HighContrast modu
                    {
                        if (ctrl is Form || ctrl is Panel)
                        {
                            ctrl.BackColor = Color.Black; // Form ve paneller siyah
                        }
                        else if (ctrl is PictureBox)
                        {
                            ctrl.BackColor = Color.White; // Sadece PictureBox beyaz
                        }
                        else
                        {
                            ctrl.BackColor = Color.Black; // diğer kontrollerin arka planı siyah
                        }

                        // Yazı rengi
                        ctrl.ForeColor = Color.White;
                    }
                    else // Normal mod
                    {
                        // Form ve paneller MediumTurquoise
                        if (ctrl is Form || ctrl is Panel || ctrl is PictureBox)
                            ctrl.BackColor = Color.MediumTurquoise;

                        // Label ve CheckBox arka planı turkuaz
                        if (ctrl is Label || ctrl is CheckBox)
                            ctrl.BackColor = Color.MediumTurquoise;
                        // Button, TextBox vb. arka plan beyaz
                        else if (!(ctrl is PictureBox || ctrl is Panel || ctrl is Form || ctrl is Label || ctrl is CheckBox))
                            ctrl.BackColor = Color.White;

                        // Yazı rengi
                        if (ctrl.Tag != null && ctrl.Tag.ToString() == "Baslik")
                            ctrl.ForeColor = Color.Red; // başlık kırmızı
                        else
                            ctrl.ForeColor = Color.Black; // diğer yazılar siyah
                    }
                }
                catch { }

                if (ctrl.HasChildren)
                    ApplyHighContrast(ctrl.Controls, aktif, mainForm);
            }
        }
    }
}