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
            openFileDialog1.Title = "Bir Resim Seçiniz";
            openFileDialog1.FileName = "Resim Seç";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "JPEG Dosyaları (*.jpeg)|*.jpeg|JPG Dosyaları (*.jpg)" +
                "|*.jpg|PNG Dosyaları (*.png)|*.png|Tüm Dosyalar (*.*)|*.*";
            openFileDialog1.FilterIndex = 4;
        }//dialog ayarları açılır sekme için
        private void resimYukleLabel_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(openFileDialog1.FileName);//resim yükleme
            }
        }
        private void Form2_Shown(object sender, EventArgs e)
        {
            ActiveControl = null;
            AccessSettings.SaveOriginalValues(this); // Orijinal değerleri kaydet
            if (AccessSettings.BiggerFontAktif)
                AccessSettings.ScaleUI(this, true);
            if (AccessSettings.DisleksiModuAktif)
                AccessSettings.AdjustForDyslexia(this, AccessSettings.DisleksiModuAktif);
        }
        private void kaydetButton_Click(object sender, EventArgs e)
        {
            string turkcesi = trTextBox.Text;
            string ingilizcesi = enTextBox.Text;
            string ornekcumle = sentenceTextBox.Text;
            string resim = openFileDialog1.FileName;//bilgieri ilgili yerlere kaydeder
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
            KelimeDeposu.kelimeListesi.Add(yeniKelime);//yeni kelimeyi listeye ekler
            MessageBox.Show("Kelime ekleme işlemi başarıyla tamamlandı!",
                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();//ve anasayfaya atar
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
            KelimeDeposu.kelimeListesi.Add(yeniKelime);//yeni kelimeyi listeye ekler ve devam eder
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
            pictureBox.Image = null;//tüm textbox ve resimi temizler sıfırlar
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            Hide();
        }
    }
}
