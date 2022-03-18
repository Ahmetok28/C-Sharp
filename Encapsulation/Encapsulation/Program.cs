using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci();
            o1.Adı = "Ahmet";
            o1.Soyadı = "ÖK";
            o1.OgrNo = 270;
            o1.Sinif = 8;
            o1.ogrenciBilgileriGetri();
            o1.sinifAtlat();
            o1.ogrenciBilgileriGetri();

            Ogrenci o2 = new Ogrenci("Ali","Veli",543,1);
            o2.ogrenciBilgileriGetri();
            o2.sinifDusur();
            o2.ogrenciBilgileriGetri();
        }
    }
    class Ogrenci
    {
        private string adı;
        private string soyadı;
        private int ogrNo;
        private int sinif;

        public Ogrenci()
        {
        }

        public string Adı 
        {
            get { return adı; }
            set {  adı = value;} 
        }
        public string Soyadı { get => soyadı; set => soyadı = value; }
        public int OgrNo { get => ogrNo; set => ogrNo = value; }
        public int Sinif 
        {   get => sinif;
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf 1 den düşük olamaz");
                    sinif = 1;
                }

                else { sinif = value; }
                 
            } 
        }

        public Ogrenci(string adı, string soyadı, int ogrNo, int sinif)
        {
            Adı = adı;
            Soyadı = soyadı;
            OgrNo = ogrNo;
            Sinif = sinif;
        }

        public void ogrenciBilgileriGetri()
        {
            Console.WriteLine("############## Öğrenci Bilgileri #############");
            Console.WriteLine("Öğrenci Adı       :{0}",Adı);
            Console.WriteLine("Öğrenci Soyadı    :{0}",Soyadı);
            Console.WriteLine("Öğrenci Numarası  :{0}",OgrNo);
            Console.WriteLine("Öğrenci Sınıfı    :{0}",Sinif);
        }

        public void sinifAtlat()
        {
            this.Sinif = this.Sinif+ 1;
        }
        public void sinifDusur()
        {
            
            this.Sinif = this.Sinif- 1;
        }
    }
}
