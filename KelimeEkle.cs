using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeEzberlemeYazilimi
{
    public partial class KelimeEkle : Form
    {
        public KelimeEkle()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Hide();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = KelimeEzberlemeYazilimi.Resource1.speaker_gif;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = KelimeEzberlemeYazilimi.Resource1.speaker;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            PanelOrtalama();
            openFileDialog1.Title = "Bir Resim Seçiniz";
            openFileDialog1.FileName = "Resim Seç";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "JPEG Dosyaları (*.jpeg)|*.jpeg|JPG Dosyaları (*.jpg)" +
                "|*.jpg|PNG Dosyaları (*.png)|*.png|Tüm Dosyalar (*.*)|*.*";
            openFileDialog1.FilterIndex = 4;
        }
        private void resimYukleLabel_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(openFileDialog1.FileName);
            }
        }
        private void PanelOrtalama()
        {
            if (kelimePanel != null)
            {
                kelimePanel.Left = (ClientSize.Width - kelimePanel.Width) / 2;
                kelimePanel.Top = (ClientSize.Height - kelimePanel.Height) / 2;
            }
        }
        private void Form2_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
        private void kaydetButton_Click(object sender, EventArgs e)
        {
            string turkcesi = trTextBox.Text;
            string ingilizcesi = enTextBox.Text;
            string ornekcumle = sentenceTextBox.Text;
            string resim = openFileDialog1.FileName;
            if (string.IsNullOrWhiteSpace(resim))
            {
                resim = null;
            }
            Kelime yeniKelime = new Kelime
            {
                TurkceKelime = turkcesi,
                IngilizceKarsiligi = ingilizcesi,
                OrnekCumle = ornekcumle,
                Resim = resim,
                BilinmeSeviyesi = 0,
                SonrakiTekrarGunu = 0,
                YanlisYapmaSayisi = 0,
            };
            KelimeDeposu.kelimeListesi.Add(yeniKelime);
            MessageBox.Show("Kelime ekleme işlemi başarıyla tamamlandı!",
                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Hide();
        }
        private void temizleButton_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void devamButton_Click(object sender, EventArgs e)
        {
            string turkcesi = trTextBox.Text;
            string ingilizcesi = enTextBox.Text;
            string ornekcumle = sentenceTextBox.Text;
            string resim = openFileDialog1.FileName;
            if (string.IsNullOrWhiteSpace(resim))
            {
                resim = null;
            }
            Kelime yeniKelime = new Kelime
            {
                TurkceKelime = turkcesi,
                IngilizceKarsiligi = ingilizcesi,
                OrnekCumle = ornekcumle,
                Resim = resim,
                BilinmeSeviyesi = 0,
                SonrakiTekrarGunu = 0,
                YanlisYapmaSayisi = 0,
            };
            KelimeDeposu.kelimeListesi.Add(yeniKelime);
            MessageBox.Show("Kelime ekleme işlemi başarıyla tamamlandı!\n" +
                "Sıradaki kelimeyi ekleyebilirsiniz.",
                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }
        private void temizle()
        {
            trTextBox.Clear();
            enTextBox.Clear();
            sentenceTextBox.Clear();
            pictureBox.Image = null;
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Hide();
        }
    }
}
