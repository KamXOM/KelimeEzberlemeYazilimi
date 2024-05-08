using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeEzberlemeYazilimi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        private static Anasayfa instance;
        public static int SoruSayisi = 10;
        private bool gunatlandi = false;
        private Rapor raporEkrani;
        public static Anasayfa GetInstance()
        {
            if (instance == null)
            {
                instance = new Anasayfa();
            }
            return instance;
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = KelimeEzberlemeYazilimi.Resource1.settings_gif;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = KelimeEzberlemeYazilimi.Resource1.settings;
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
        private void Anasayfa_Shown(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
            panel1.Visible = true;
            checkBox1.Checked = false;
            gunatlandi = false;
            if (GirisYap.GirisYapildi == true)
            {
                girisYapButton.Visible = false;
                kayitOlButton.Visible = false;
                sinavaBaslaButton.Visible = true;
                kelimeEkleButton.Visible = true;
                raporButton.Visible = true;
            }
            else
            {
                girisYapButton.Visible = true;
                kayitOlButton.Visible = true;
                sinavaBaslaButton.Visible = false;
                kelimeEkleButton.Visible = false;
                raporButton.Visible = false;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = true;
            panel1.Visible = false;
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = KelimeEzberlemeYazilimi.Resource1.settings_gif;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = KelimeEzberlemeYazilimi.Resource1.settings;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            settingsPanel.Visible = false;
        }

        private void Anasayfa_ClientSizeChanged(object sender, EventArgs e)
        {
            if (settingsPanel.Visible)
            {
                settingsPanel.Left = (ClientSize.Width - settingsPanel.Width) / 2;
                settingsPanel.Top = (ClientSize.Height - settingsPanel.Height) / 2;
            }
            else
            {
                panel1.Left = (ClientSize.Width - panel1.Width) / 2;
                panel1.Top = (ClientSize.Height - panel1.Height) / 2;
            }
        }

        private void sinavaBaslaButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SoruSayisi = (int)numericUpDown1.Value;
            }
            if (!gunatlandi)
            {
                foreach (Kelime kelime in KelimeDeposu.kelimeListesi)
                {
                    if (kelime.SonrakiTekrarGunu > 0)
                    {
                        kelime.SonrakiTekrarGunu--;
                    }
                }
            }

            //SinavEkrani sinavekrani = SinavEkrani.GetInstance();
            SinavEkrani sinavekrani = new SinavEkrani();
            sinavekrani.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilengun = comboBox1.SelectedIndex;
            int atlanacakgun;
            gunatlandi = true;
            switch (secilengun)
            {
                case 0: atlanacakgun = 1; break;
                case 1: atlanacakgun = 7; break;
                case 2: atlanacakgun = 30; break;
                case 3: atlanacakgun = 90; break;
                case 4: atlanacakgun = 180; break;
                case 5: atlanacakgun = 360; break;
                default: MessageBox.Show("Geçersiz gün seçimi!"); return;
            }
            foreach (Kelime kelime in KelimeDeposu.kelimeListesi)
            {
                if (kelime.SonrakiTekrarGunu > 0)
                {
                    kelime.SonrakiTekrarGunu -= atlanacakgun;
                    if (kelime.SonrakiTekrarGunu < 0)
                    {
                        kelime.SonrakiTekrarGunu = 0;
                        kelime.BilinmeSeviyesi = 0;
                    }
                }
            }
            MessageBox.Show(atlanacakgun + " gün atlandı!");
        }

        private void kayitOlButton_Click(object sender, EventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
            Hide();
        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            GirisYap girisyap = new GirisYap();
            girisyap.Show();
            Hide();
        }

        private void kelimeEkleButton_Click(object sender, EventArgs e)
        {
            KelimeEkle kelimeekle = new KelimeEkle();
            kelimeekle.Show();
            Hide();
        }

        private void raporButton_Click(object sender, EventArgs e)
        {
            RaporEkraniAc();
        }
        private void RaporEkraniAc()
        {
            if (raporEkrani == null || raporEkrani.IsDisposed)
            {
                raporEkrani = new Rapor();
                raporEkrani.FormClosed += Rapor_FormClosed;
                raporEkrani.Show();
                Hide();
            }
            else
            {
                raporEkrani.Activate();
            }
        }
        private void Rapor_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Rapor ekranı kapatıldığında Anasayfa formunu yeniden aç
            Show();
            Activate();
        }
    }
}
