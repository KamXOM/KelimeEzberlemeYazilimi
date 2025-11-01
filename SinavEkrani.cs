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
            sinavListesi.Clear();//listelerin ne olur ne olmaz temizlenmesi
            kullaniciCevaplari.Clear();
            soruIndex = 0;//index 0 lanması
            Random rastgele = new Random();
            while (KelimeDeposu.kelimeListesi.Any(k => !sinavListesi.Contains(k) &&
            k.BilinmeSeviyesi > 0 && k.SonrakiTekrarGunu == 0))
            {//öncelik sınavlistesinde olmayan bilinme sayısı 0 dan fazla olan tekrar günü gelen
                Kelime rastgeleKelime = KelimeDeposu.kelimeListesi
                    [rastgele.Next(KelimeDeposu.kelimeListesi.Count)];
                if (!sinavListesi.Contains(rastgeleKelime) && rastgeleKelime.BilinmeSeviyesi > 0
                    && rastgeleKelime.SonrakiTekrarGunu == 0)
                {
                    sinavListesi.Add(rastgeleKelime);
                }
            }
            int j = 0;
            while (j < Anasayfa.SoruSayisi)//yeni kelime
            {
                Kelime rastgeleKelime = KelimeDeposu.kelimeListesi
                    [rastgele.Next(KelimeDeposu.kelimeListesi.Count)];
                if (!sinavListesi.Contains(rastgeleKelime) && rastgeleKelime.BilinmeSeviyesi == 0
                    && rastgeleKelime.SonrakiTekrarGunu == 0)
                {//daha önceden bilinmemiş yeni kelime eklenmesi
                    sinavListesi.Add(rastgeleKelime);
                    j++;
                }
            }
            foreach (Kelime kelime in sinavListesi)
            {
                string buyukBasHarf = char.ToUpper(kelime.TurkceKelime[0]) +
                    kelime.TurkceKelime.Substring(1);
                kelimeComboBox.Items.Add(buyukBasHarf);
            }//açılır listeye baş harfi büyük öğeler eklenmesi
            string buyukBasHarfli = char.ToUpper(sinavListesi[0].TurkceKelime[0]) +
                    sinavListesi[0].TurkceKelime.Substring(1);
            turkceTextBox.Text = buyukBasHarfli;
            if (!string.IsNullOrWhiteSpace(sinavListesi[0].Resim))
            {
                pictureBox1.Image = Image.FromFile(sinavListesi[0].Resim);
            }//resim koyma 
            kullaniciCevaplari.Clear();
            for (int i = 0; i < sinavListesi.Count; i++)
            {
                kullaniciCevaplari.Add("");//kullanıcı cevapları listesini hazırlama
            }
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = KelimeEzberlemeYazilimi.Resource1.speaker_gif;
        }
        //tatlı bir gif koyma
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = KelimeEzberlemeYazilimi.Resource1.speaker;
        }

        private void sonrakiButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cevapTextBox.Text))
            {
                kullaniciCevaplari[soruIndex] = cevapTextBox.Text.ToLower();
            }//cevabı cevap listesine kaydetme
            soruIndex++;
            if (soruIndex >= sinavListesi.Count)
            {
                soruIndex = 0;//sona geldiyse başa dönme
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
            }//önceden cevap girildiyse onu getirir
            else { cevapTextBox.Clear(); }
            cevapTextBox.Focus();
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
        {//combobox değişimi
            if (!string.IsNullOrWhiteSpace(cevapTextBox.Text))
            {
                kullaniciCevaplari[soruIndex] = cevapTextBox.Text.ToLower();
            }//cevabı kaydet boş değilse
            else { kullaniciCevaplari[soruIndex] = ""; }
            soruIndex = kelimeComboBox.SelectedIndex;
            string buyukBasHarf = char.ToUpper(sinavListesi[soruIndex].TurkceKelime[0]) +
                sinavListesi[soruIndex].TurkceKelime.Substring(1);
            turkceTextBox.Text = buyukBasHarf;//combobox a adını yaz
            if (!string.IsNullOrWhiteSpace(sinavListesi[soruIndex].Resim))
            {
                pictureBox1.Image = Image.FromFile(sinavListesi[soruIndex].Resim);
            }//resim varsa koy
            else { pictureBox1.Image = null; }
            if (!string.IsNullOrWhiteSpace(kullaniciCevaplari[soruIndex]))
            {
                cevapTextBox.Text = kullaniciCevaplari[soruIndex];
            }//cevabı getir varsa
            else { cevapTextBox.Clear(); }
        }
        private void sinavBitirButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cevapTextBox.Text))
            {//cevap varsa kaydet
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
            {   //cevap yoksa boş atıyor varsa kullanıcı cevaplarından ilgili cevabı atıyor
                string kullaniciCevabi = string.IsNullOrEmpty(kullaniciCevaplari[i]) ? "" : kullaniciCevaplari[i].ToLower();
                string dogruCevap = sinavListesi[i].IngilizceKarsiligi.ToLower();
                kullaniciCevabi = kullaniciCevabi.Replace(" ", "");
                dogruCevap = dogruCevap.Replace(" ", "");
                if (!string.IsNullOrWhiteSpace(kullaniciCevabi))
                {
                    if (kullaniciCevabi == dogruCevap)
                    {
                        KelimeDeposu.BilinmeSeviyesiniArttir(sinavListesi[i].TurkceKelime, true);
                        MessageBox.Show("Soru " + (i + 1) + " doğru!");
                    }//doğruysa
                    else
                    {
                        KelimeDeposu.BilinmeSeviyesiniArttir(sinavListesi[i].TurkceKelime, false);
                        MessageBox.Show("Soru " + (i + 1) + " yanlış!");
                    }//yanlışsa
                }
                else
                {
                    KelimeDeposu.BilinmeSeviyesiniArttir(sinavListesi[i].TurkceKelime, false);
                    MessageBox.Show("Soru " + (i + 1) + " boş!");
                }//boşsa ama yanlışla aynı işlem yapılıyor
            }
        }

        private void SinavEkrani_Shown(object sender, EventArgs e)
        {

        }
    }
}