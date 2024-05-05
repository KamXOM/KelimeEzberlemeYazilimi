using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzberlemeYazilimi
{
    public class Kullanici
    {
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public string FavKelime { get; set; }
    }
    public class KayitliKullaniciListesi
    {
        public static List<Kullanici> kayitliKullanicilar = new List<Kullanici>();
    }
}
