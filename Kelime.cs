using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KelimeEzberlemeYazilimi
{
    public class Kelime
    {
        public string TurkceKelime { get; set; }
        public string IngilizceKarsiligi { get; set; }
        public string OrnekCumle { get; set; }
        public string Resim { get; set; }
        public int BilinmeSeviyesi { get; set; }
        public int YanlisYapmaSayisi { get; set; }
        public int SonrakiTekrarGunu { get; set; }
    }
    public class KelimeDeposu
    {
        public static List<Kelime> kelimeListesi = new List<Kelime>();
        static string dosyaYolu = "C:\\Users\\onurm\\source\\repos\\KelimeEzberlemeYazilimi\\" +
            "KelimeEzberlemeYazilimi\\kelimeler.txt";
        public static void txtdenOku()
        {
            string[] satirlar = File.ReadAllLines(dosyaYolu);

            for (int i = 0; i < satirlar.Length; i++)
            {
                string[] parcalar = satirlar[i].Split(',');
                string turkce = parcalar[0];
                string ingilizce = parcalar[1];
                string ornekCumle = parcalar[2];

                Kelime kelime = new Kelime
                {
                    TurkceKelime = turkce,
                    IngilizceKarsiligi = ingilizce,
                    OrnekCumle = ornekCumle,
                    BilinmeSeviyesi = 0,
                    SonrakiTekrarGunu = 0,
                    YanlisYapmaSayisi = 0,
                };
                kelimeListesi.Add(kelime);
            }
        }
        public static void resimEkle()
        {
            string resimKlasoru = "C:\\Users\\onurm\\source\\repos\\KelimeEzberlemeYazilimi" +
                "\\KelimeEzberlemeYazilimi\\resimler";
            string[] resimDosyalari = Directory.GetFiles(resimKlasoru);
            foreach (string resimDosyasi in resimDosyalari)
            {
                string dosyaAdi = Path.GetFileNameWithoutExtension(resimDosyasi);
                foreach (Kelime kelime in kelimeListesi)
                {
                    if (string.Equals(dosyaAdi, kelime.TurkceKelime, StringComparison.OrdinalIgnoreCase))
                    {
                        kelime.Resim = resimDosyasi;
                        break;
                    }
                }
            }
        }
        public static void BilinmeSeviyesiniArttir(string turkce, bool dogrumu)
        {
            foreach (Kelime kelime in kelimeListesi)
            {
                if (kelime.TurkceKelime.Equals(turkce, StringComparison.OrdinalIgnoreCase))
                {
                    if (dogrumu)
                    {
                        kelime.BilinmeSeviyesi++;
                        switch (kelime.BilinmeSeviyesi)
                        {
                            case 1:
                                kelime.SonrakiTekrarGunu = 1; break;
                            case 2:
                                kelime.SonrakiTekrarGunu = 7; break;
                            case 3:
                                kelime.SonrakiTekrarGunu = 30; break;
                            case 4:
                                kelime.SonrakiTekrarGunu = 90; break;
                            case 5:
                                kelime.SonrakiTekrarGunu = 180; break;
                            case 6:
                                kelime.SonrakiTekrarGunu = 360; break;//1 ay 30 gün 1 yıl :(
                            case 7:
                                kelime.BilinmeSeviyesi = -1; break;
                            default:
                                MessageBox.Show("Bir sorun var!" + kelime.TurkceKelime +
                                kelime.BilinmeSeviyesi + kelime.SonrakiTekrarGunu); break;
                        }
                    }
                    else
                    {
                        kelime.BilinmeSeviyesi = 0;
                        kelime.SonrakiTekrarGunu = 0;
                        kelime.YanlisYapmaSayisi++;
                    }
                    break;
                }
            }
        }
    }
}