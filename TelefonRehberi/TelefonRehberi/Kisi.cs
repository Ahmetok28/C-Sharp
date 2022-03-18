using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class Kisi
    {
        private string ad;
        private string soyAd;
        private int telefonNumarası;

        public string Ad { get => ad; set => ad = value; }
        public string SoyAd { get => soyAd; set => soyAd = value; }
        public int TelefonNumarası { get => telefonNumarası; set => telefonNumarası = value; }

        public Kisi(string ad, string soyAd, int telefonNumarası)
        {
            Ad = ad;
            SoyAd = soyAd;
            TelefonNumarası = telefonNumarası;
        }

       

        public void kisiBilgileri()
        {
            Console.WriteLine("telefon rehberi");
            Console.WriteLine("*******************");
            Console.WriteLine("Adı: {0}",Ad);
            Console.WriteLine("SoyAdı: {0}",SoyAd);
            Console.WriteLine("Telefon Numarası: {0}",TelefonNumarası);
        }

        public Kisi()
        {
        }

    }
}
