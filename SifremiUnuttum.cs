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
                {
                    basarili = true;
                    this.kullanici = kullanici;
                    break;
                }
            }
            if (basarili) { devamEdiyoruz(); }
            else
            {
                MessageBox.Show("E-Posta veya Favori Kelimeniz Doğru Değil!",
                "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void devamEdiyoruz()
        {
            //favkelimeLabel.Visible = false;
            //emailLabel.Visible = false;
            //SifreOnayLabel.Visible = true;
            //sifreLabel.Visible = true;
            //sifreTextBox.Visible = true;
            //sifreOnayTextBox.Visible = true;
            //emailTextBox.Visible = false;
            //favkelimeTextBox.Visible = false;
            //devamButton.Visible = false;
            //onaylaButton.Visible = true;
            panel1.Visible = false;
            panel2.Visible = true;
        }
        private void onaylaButton_Click(object sender, EventArgs e)
        {
            if (sifreTextBox.Text == sifreOnayTextBox.Text)
            {
                kullanici.Sifre = sifreTextBox.Text;
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
        {
            GirisYap girisyapmaformu = new GirisYap();
            girisyapmaformu.Show();
            Hide();
        }
    }
}
