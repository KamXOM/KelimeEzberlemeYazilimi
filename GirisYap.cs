using System.Windows.Forms;
using System;

namespace KelimeEzberlemeYazilimi
{
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }
        public static bool GirisYapildi = false;
        private void girisButton_Click(object sender, EventArgs e)
        {   //doðruysa true döndürür
            bool girisBasarili = GirisYapma.GirisKontrol(emailTextBox.Text,sifreTextBox.Text);
            if (girisBasarili)
            {
                MessageBox.Show("Giriþ baþarýyla yapýldý!","Baþarýlý!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                GirisYapildi = true;
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                Hide();
            }
            else
            {//yanlýþsa mesaj
                MessageBox.Show("E-posta veya þifre hatalý. Lütfen tekrar deneyin.",
                    "Baþarýsýz!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void unuttumButton_Click(object sender, EventArgs e)
        {//unuttum sayfasý
            SifremiUnuttum sifreformu = new SifremiUnuttum();
            sifreformu.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (AccessSettings.DisleksiModuAktif)
            {
                AccessSettings.ChangeFontFamily(this.Controls, AccessSettings.DisleksiFont);
            }
            else
                AccessSettings.ChangeFontFamily(this.Controls, AccessSettings.NormalFont);
            AccessSettings.ApplyHighContrast(this.Controls, AccessSettings.HighContrastAktif, this);
            AccessSettings.SaveOriginalValues(this); // Orijinal deðerleri kaydet
            if (AccessSettings.BiggerFontAktif)
                AccessSettings.ScaleUI(this, true);
            if (AccessSettings.DisleksiModuAktif)
                AccessSettings.AdjustForDyslexia(this, AccessSettings.DisleksiModuAktif);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
            AccessSettings.SaveOriginalValues(this); // Orijinal deðerleri kaydet
            if (AccessSettings.BiggerFontAktif)
                AccessSettings.ScaleUI(this, true);
            if (AccessSettings.DisleksiModuAktif)
                AccessSettings.AdjustForDyslexia(this, AccessSettings.DisleksiModuAktif);
        }

        private void geriButton_Click(object sender, EventArgs e)
        {//geri butonu anasayfa açar
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Hide();
        }
    }
}
