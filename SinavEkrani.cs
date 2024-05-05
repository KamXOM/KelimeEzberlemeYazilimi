using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KelimeEzberlemeYazilimi
{
    public partial class SinavEkrani : Form
    {
        private static SinavEkrani instance;
        public static SinavEkrani GetInstance()
        {
            if (instance == null)
            {
                instance = new SinavEkrani();
            }
            return instance;
        }
        public SinavEkrani()
        {
            InitializeComponent();
            sinavListesi = new List<Kelime>();
        }
        List<Kelime> sinavListesi;
        List<string> kullaniciCevaplari = new List<string>();
        int soruIndex = 0;
        private void SinavEkrani_Load(object sender, EventArgs e)
        {
            sinavListesi.Clear();
            kullaniciCevaplari.Clear();
            soruIndex = 0;
            Random rastgele = new Random();
            while (KelimeDeposu.kelimeListesi.Any(k => !sinavListesi.Contains(k) &&
            k.BilinmeSeviyesi > 0 && k.SonrakiTekrarGunu == 0))
            {
                Kelime rastgeleKelime = KelimeDeposu.kelimeListesi
                    [rastgele.Next(KelimeDeposu.kelimeListesi.Count)];
                if (!sinavListesi.Contains(rastgeleKelime) && rastgeleKelime.BilinmeSeviyesi > 0
                    && rastgeleKelime.SonrakiTekrarGunu == 0)
                {
                    sinavListesi.Add(rastgeleKelime);
                }
            }
            int j = 0;
            while (j < Anasayfa.SoruSayisi)
            {
                Kelime rastgeleKelime = KelimeDeposu.kelimeListesi
                    [rastgele.Next(KelimeDeposu.kelimeListesi.Count)];
                if (!sinavListesi.Contains(rastgeleKelime) && rastgeleKelime.BilinmeSeviyesi == 0
                    && rastgeleKelime.SonrakiTekrarGunu == 0)
                {
                    sinavListesi.Add(rastgeleKelime);
                    j++;
                }
            }
            foreach (Kelime kelime in sinavListesi)
            {
                string buyukBasHarf = char.ToUpper(kelime.TurkceKelime[0]) +
                    kelime.TurkceKelime.Substring(1);
                kelimeComboBox.Items.Add(buyukBasHarf);
            }
            string buyukBasHarfli = char.ToUpper(sinavListesi[0].TurkceKelime[0]) +
                    sinavListesi[0].TurkceKelime.Substring(1);
            turkceTextBox.Text = buyukBasHarfli;
            if (!string.IsNullOrWhiteSpace(sinavListesi[0].Resim))
            {
                pictureBox1.Image = Image.FromFile(sinavListesi[0].Resim);
            }
            kullaniciCevaplari.Clear();
            for (int i = 0; i < Anasayfa.SoruSayisi; i++)
            {
                kullaniciCevaplari.Add("");
            }
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = KelimeEzberlemeYazilimi.Resource1.speaker_gif;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = KelimeEzberlemeYazilimi.Resource1.speaker;
        }

        private void sonrakiButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cevapTextBox.Text))
            {
                kullaniciCevaplari[soruIndex] = cevapTextBox.Text.ToLower();
            }
            soruIndex++;
            if (soruIndex >= sinavListesi.Count)
            {
                soruIndex = 0;//başa dönüyo
            }
            kelimeComboBox.SelectedIndex = soruIndex;
            string buyukBasHarf = char.ToUpper(sinavListesi[soruIndex].TurkceKelime[0]) +
                    sinavListesi[soruIndex].TurkceKelime.Substring(1);
            turkceTextBox.Text = buyukBasHarf;
            if (!string.IsNullOrWhiteSpace(sinavListesi[soruIndex].Resim))
            {
                pictureBox1.Image = Image.FromFile(sinavListesi[soruIndex].Resim);
            }
            else { pictureBox1.Image = null; }
            if (kullaniciCevaplari.Count > soruIndex)
            {
                cevapTextBox.Text = kullaniciCevaplari[soruIndex];
            }
            else { cevapTextBox.Clear(); }
        }

        private void oncekiButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cevapTextBox.Text))
            {
                kullaniciCevaplari[soruIndex] = cevapTextBox.Text.ToLower();
            }
            soruIndex--;
            if (soruIndex < 0)
            {
                soruIndex = sinavListesi.Count - 1;
            }
            kelimeComboBox.SelectedIndex = soruIndex;
            string buyukBasHarf = char.ToUpper(sinavListesi[soruIndex].TurkceKelime[0]) +
                    sinavListesi[soruIndex].TurkceKelime.Substring(1);
            turkceTextBox.Text = buyukBasHarf;
            if (!string.IsNullOrWhiteSpace(sinavListesi[soruIndex].Resim))
            {
                pictureBox1.Image = Image.FromFile(sinavListesi[soruIndex].Resim);
            }
            else { pictureBox1.Image = null; }
            if (kullaniciCevaplari.Count > soruIndex)
            {
                cevapTextBox.Text = kullaniciCevaplari[soruIndex];
            }
            else { cevapTextBox.Clear(); }
        }
        private void kelimeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cevapTextBox.Text))
            {
                kullaniciCevaplari[soruIndex] = cevapTextBox.Text.ToLower();
            }
            else { kullaniciCevaplari[soruIndex] = ""; }
            soruIndex = kelimeComboBox.SelectedIndex;
            string buyukBasHarf = char.ToUpper(sinavListesi[soruIndex].TurkceKelime[0]) +
                sinavListesi[soruIndex].TurkceKelime.Substring(1);
            turkceTextBox.Text = buyukBasHarf;
            if (!string.IsNullOrWhiteSpace(sinavListesi[soruIndex].Resim))
            {
                pictureBox1.Image = Image.FromFile(sinavListesi[soruIndex].Resim);
            }
            else { pictureBox1.Image = null; }
            if (!string.IsNullOrWhiteSpace(kullaniciCevaplari[soruIndex]))
            {
                cevapTextBox.Text = kullaniciCevaplari[soruIndex];
            }
            else { cevapTextBox.Clear(); }
        }
        private void sinavBitirButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cevapTextBox.Text))
            {
                kullaniciCevaplari[soruIndex] = cevapTextBox.Text.ToLower();
            }
            KontrolEt();
            Anasayfa anasayfa = Anasayfa.GetInstance();
            anasayfa.Show();
            Hide();
        }
        private void KontrolEt()
        {
            for (int i = 0; i < sinavListesi.Count; i++)
            {
                string kullaniciCevabi = string.IsNullOrEmpty(kullaniciCevaplari[i]) ? "" : kullaniciCevaplari[i].ToLower();
                string dogruCevap = sinavListesi[i].IngilizceKarsiligi.ToLower();
                kullaniciCevabi = kullaniciCevabi.Replace(" ", "");
                dogruCevap = dogruCevap.Replace(" ", "");
                if (!string.IsNullOrWhiteSpace(kullaniciCevabi))
                {
                    if (kullaniciCevabi == dogruCevap)
                    {
                        MessageBox.Show("Kelime:" + sinavListesi[i].TurkceKelime + sinavListesi[i].BilinmeSeviyesi + sinavListesi[i].SonrakiTekrarGunu);
                        KelimeDeposu.BilinmeSeviyesiniArttir(sinavListesi[i].TurkceKelime, true);
                        MessageBox.Show("Soru " + (i + 1) + " doğru!");
                        MessageBox.Show("Kelime:" + sinavListesi[i].TurkceKelime + sinavListesi[i].BilinmeSeviyesi + sinavListesi[i].SonrakiTekrarGunu);
                    }
                    else
                    {
                        MessageBox.Show("Kelime:" + sinavListesi[i].TurkceKelime + sinavListesi[i].BilinmeSeviyesi + sinavListesi[i].SonrakiTekrarGunu);
                        KelimeDeposu.BilinmeSeviyesiniArttir(sinavListesi[i].TurkceKelime, false);
                        MessageBox.Show("Soru " + (i + 1) + " yanlış!");
                        MessageBox.Show("Kelime:" + sinavListesi[i].TurkceKelime + sinavListesi[i].BilinmeSeviyesi + sinavListesi[i].SonrakiTekrarGunu);
                    }
                }
                else
                {
                    MessageBox.Show("Kelime:" + sinavListesi[i].TurkceKelime + sinavListesi[i].BilinmeSeviyesi + sinavListesi[i].SonrakiTekrarGunu);
                    KelimeDeposu.BilinmeSeviyesiniArttir(sinavListesi[i].TurkceKelime, false);
                    MessageBox.Show("Soru " + (i + 1) + " boş!");
                    MessageBox.Show("Kelime:" + sinavListesi[i].TurkceKelime + sinavListesi[i].BilinmeSeviyesi + sinavListesi[i].SonrakiTekrarGunu);
                }
            }
        }

        private void SinavEkrani_Shown(object sender, EventArgs e)
        {
            /*sinavListesi.Clear();
            kullaniciCevaplari.Clear();
            soruIndex = 0;
            Random rastgele = new Random();
            while (KelimeDeposu.kelimeListesi.Any(k => !sinavListesi.Contains(k) &&
            k.BilinmeSeviyesi > 0 && k.SonrakiTekrarGunu == 0))
            {
                Kelime rastgeleKelime = KelimeDeposu.kelimeListesi
                    [rastgele.Next(KelimeDeposu.kelimeListesi.Count)];
                if (!sinavListesi.Contains(rastgeleKelime) && rastgeleKelime.BilinmeSeviyesi > 0
                    && rastgeleKelime.SonrakiTekrarGunu == 0)
                {
                    sinavListesi.Add(rastgeleKelime);
                }
            }
            while (sinavListesi.Count < Anasayfa.SoruSayisi)
            {
                Kelime rastgeleKelime = KelimeDeposu.kelimeListesi
                    [rastgele.Next(KelimeDeposu.kelimeListesi.Count)];
                if (!sinavListesi.Contains(rastgeleKelime) && rastgeleKelime.BilinmeSeviyesi == 0
                    && rastgeleKelime.SonrakiTekrarGunu == 0)
                {
                    sinavListesi.Add(rastgeleKelime);
                }
            }
            foreach (Kelime kelime in sinavListesi)
            {
                string buyukBasHarf = char.ToUpper(kelime.TurkceKelime[0]) +
                    kelime.TurkceKelime.Substring(1);
                kelimeComboBox.Items.Add(buyukBasHarf);
            }
            string buyukBasHarfli = char.ToUpper(sinavListesi[0].TurkceKelime[0]) +
                    sinavListesi[0].TurkceKelime.Substring(1);
            turkceTextBox.Text = buyukBasHarfli;
            if (!string.IsNullOrWhiteSpace(sinavListesi[0].Resim))
            {
                pictureBox1.Image = Image.FromFile(sinavListesi[0].Resim);
            }
            kullaniciCevaplari.Clear();
            for (int i = 0; i < Anasayfa.SoruSayisi; i++)
            {
                kullaniciCevaplari.Add("");
            }*/
        }
    }
}