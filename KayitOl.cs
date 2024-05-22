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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            PanelOrtalama();
        }

        private void PanelOrtalama()
        {
            if (panel1 != null)
            {
                panel1.Left = (ClientSize.Width - panel1.Width) / 2;
                panel1.Top = (ClientSize.Height - panel1.Height) / 2;
            }
        }

        private void kayitButton_Click(object sender, EventArgs e)
        {
            bool kayitlimi = false;
            string eposta = emailTextBox.Text;
            string sifre = sifreTextBox.Text;
            string favkelime = favkelimeTextBox.Text;
            foreach (Kullanici kullanici in KayitliKullaniciListesi.kayitliKullanicilar)
            {
                if (kullanici.Eposta == eposta)
                {
                    MessageBox.Show("Bu E-Posta zaten kayıtlı. Lütfen Giriş Yapınız.",
                    "Kayıt Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kayitlimi = true;//e posta zaten kayıtlıysa uyarı mesajı
                    break;
                }
            }
            if (!kayitlimi)
            {
                Kullanici yeniKullanici = new Kullanici
                {
                    Eposta = eposta,
                    Sifre = sifre,
                    FavKelime = favkelime
                };//yeni kullanıcıyı listeye ekler
                KayitliKullaniciListesi.kayitliKullanicilar.Add(yeniKullanici);
                MessageBox.Show("Kayıt işlemi başarıyla tamamlandı!\n" +
                    "Giriş Yapabilirsiniz.", "Başarılı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                GirisYap girisyap = new GirisYap();
                girisyap.Show();
                Hide();
            }
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Hide();
        }
    }
}
