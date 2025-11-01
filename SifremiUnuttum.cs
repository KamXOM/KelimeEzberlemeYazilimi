using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeEzberlemeYazilimi
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        Kullanici kullanici;
        private void devamButton_Click(object sender, EventArgs e)
        {
            bool basarili = false;
            string email = emailTextBox.Text;
            string favkelime = favkelimeTextBox.Text;
            foreach (Kullanici kullanici in KayitliKullaniciListesi.kayitliKullanicilar)
            {
                if (kullanici.Eposta == email && kullanici.FavKelime == favkelime)
                {//eposta ve favori kelime aynıysa
                    basarili = true;
                    this.kullanici = kullanici;
                    break;
                }
            }
            if (basarili) { devamEdiyoruz(); }
            else
            {//yanlışsa
                MessageBox.Show("E-Posta veya Favori Kelimeniz Doğru Değil!",
                "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void devamEdiyoruz()
        {
            panel1.Visible = false;//eposta paneli
            panel2.Visible = true;//sifre yenileme paneli
        }
        private void onaylaButton_Click(object sender, EventArgs e)
        {
            if (sifreTextBox.Text == sifreOnayTextBox.Text)
            {
                kullanici.Sifre = sifreTextBox.Text;//yeni şifre atama
                MessageBox.Show("Her şey başarıyla tamamlandı!",
                    "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GirisYap girisyap = new GirisYap();
                girisyap.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Lütfen şifrenizi kontrol ediniz!",
                    "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void geriButton_Click(object sender, EventArgs e)
        {
            GirisYap girisyapmaformu = new GirisYap();
            girisyapmaformu.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {//2. sayfadaki geri butonu
            GirisYap girisyapmaformu = new GirisYap();
            girisyapmaformu.Show();
            Hide();
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            if (AccessSettings.DisleksiModuAktif)
            {
                AccessSettings.ChangeFontFamily(this.Controls, AccessSettings.DisleksiFont);
            }
            else
                AccessSettings.ChangeFontFamily(this.Controls, AccessSettings.NormalFont);
            AccessSettings.ApplyHighContrast(this.Controls, AccessSettings.HighContrastAktif, this);
            AccessSettings.SaveOriginalValues(this); // Orijinal değerleri kaydet
            if (AccessSettings.BiggerFontAktif)
                AccessSettings.ScaleUI(this, true);
            if (AccessSettings.DisleksiModuAktif)
                AccessSettings.AdjustForDyslexia(this, AccessSettings.DisleksiModuAktif);
        }
    }
}
