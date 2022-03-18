using System;

namespace Erişim_Belirleyiciler_ve_Kurucu_Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########### Çalışan 1 ###########");
            Calisan c1 = new Calisan("Ahmet","ÖK",12345678,"IT");
            c1.calisanBilgileri();
            Console.WriteLine("########### Çalışan 2 ###########");
            Calisan c2 = new Calisan();
            c2.ad = "Ramazan";
            c2.soyAd = "ÖK";
            c2.no = 86248525;
            c2.departman = "İK";
            c2.calisanBilgileri();
            Console.WriteLine("########### Çalışan 3 ###########");
            Calisan c3 = new Calisan("Ali", "Veli");
            c3.calisanBilgileri();
        }
    }

    class Calisan
    {
        public string ad;
        public string soyAd;
        public int no;
        public string departman;

        public Calisan(string v1, string v2, int v3, string v4)
        {
            this.ad = v1;
            this.soyAd = v2;
            this.no = v3;
            this.departman = v4;
        }

        public Calisan(string v1, string v2)
        {
            this.ad = v1;
            this.soyAd = v2;
            
        }

        public Calisan()
        {

        }

        public void calisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", ad);
            Console.WriteLine("Çalışanın SoyAdı: {0}", soyAd);
            Console.WriteLine("Çalışanın Numarası: {0}", no);
            Console.WriteLine("Çalışanın Departmanı: {0}", departman);

        }
    }
}
