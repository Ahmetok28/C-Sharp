using System;

namespace Class_vs._Instance
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Calisan c1 = new Calisan();
            c1.ad = "Ahmet";
            c1.soyAd = "ÖK";
            c1.no = 53254633;
            c1.departman = "IT";
            c1.calisanBilgileri();

            Calisan c2 = new Calisan();
            c2.ad = "Ramazan";
            c2.soyAd = "ÖK";
            c2.no = 86248525;
            c2.departman = "İK";
            c2.calisanBilgileri();

        }
    }

    class Calisan
    {
        public string ad;
        public string soyAd;
        public int no;
        public string departman;

        public void calisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}",ad);
            Console.WriteLine("Çalışanın SoyAdı: {0}",soyAd);
            Console.WriteLine("Çalışanın Numarası: {0}", no);
            Console.WriteLine("Çalışanın Departmanı: {0}",departman);
            
        }
    }
}
