using System;

namespace Static_Sinif_Uyeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"çalışan sayısı :{Calisan.CalisanSayisi} ");
            Calisan c1 = new Calisan("Ahmet", "ÖK", "IT");
            Console.WriteLine($"çalışan sayısı :{Calisan.CalisanSayisi} ");
            Calisan c2 = new Calisan("Ramazan", "ÖK", "IK");
            Calisan c3 = new Calisan("Elif", "ÖK", "CEO");
            Console.WriteLine($"çalışan sayısı :{Calisan.CalisanSayisi} ");
            Console.WriteLine("-------------------");
            Console.WriteLine(Islem.Topla(100, 200));
            Console.WriteLine(Islem.Cikar(200, 50));

            Console.ReadKey();

        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        private string ad;
        private string soyAd;
        private string departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyIsim, string departman)
        {
            this.ad = isim;
            this.soyAd = soyIsim;
            this.departman = departman;
            calisanSayisi++;
        }

        public static int CalisanSayisi
        {
            get => calisanSayisi;

        }
    }

    static class Islem
    {
        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
