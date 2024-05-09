using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzberlemeYazilimi
{
    public class GirisYapma
    {
        public static bool GirisKontrol(string eposta, string sifre)
        {
            foreach (Kullanici kullanici in KayitliKullaniciListesi.kayitliKullanicilar)
            {
                if (kullanici.Eposta == eposta && kullanici.Sifre == sifre)
                {//bilgiler doğruysa giriş true döndürür
                    return true;
                }
            }
            return false;
        }
    }
}
