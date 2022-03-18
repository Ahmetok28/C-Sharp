using System;
using System.Collections.Generic;

namespace Generic_Collectioans
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T -> object türündedir.
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(3);
            sayiListesi.Add(2);
            sayiListesi.Add(5);
            sayiListesi.Add(6);
            sayiListesi.Add(27);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("sarı");
            renkListesi.Add("yeşil");

            
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                System.Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                System.Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // listeden eleman çıkarma

            sayiListesi.Remove(4);
            renkListesi.Remove("yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => System.Console.WriteLine(renk));
            sayiListesi.RemoveAt(0); // indekse göre çıkarıır

            // Liste içerisinde arama
            if (sayiListesi.Contains(10))
            {
                System.Console.WriteLine("10 liste içerisinde bulundu ");

            }

            // eleman ile indekse erişme 

            System.Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            // Diziyi liste'ye çevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            // listeyi nasıl temizleriz?
            hayvanListesi.Clear();

            // list içerisinde nesne tutmak

            List<Kullanıcılar> kullanıcılarListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ahmet";
            kullanıcı1.Soyisim = "ÖK";
            kullanıcı1.Yas = 21;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Mehmet Akif";
            kullanıcı2.Soyisim = "ÖK";
            kullanıcı2.Yas = 22;

            kullanıcılarListesi.Add(kullanıcı1);
            kullanıcılarListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Ramazan",
                Soyisim = "ÖK",
                Yas = 28
            });

            foreach (var kullanıcı in kullanıcılarListesi)
            {
                System.Console.WriteLine("kullanıcı adı: " + kullanıcı.Isim);
                System.Console.WriteLine("kullanıcı Soyadı: " + kullanıcı.Soyisim);
                System.Console.WriteLine("kullanıcı Yaşı: " + kullanıcı.Yas);

            }
            yeniListe.Clear();


        }
    }

    public class Kullanıcılar
    {
        string isim; 
        string soyisim;
        int yas;

        
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }



    }
}

