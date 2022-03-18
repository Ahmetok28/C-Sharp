using System;

namespace MetodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outsayi);

            if (sonuc)
            {
                Console.WriteLine("İşlem başarılı");
                Console.WriteLine(outsayi);

            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            metotlar instance = new metotlar();
            instance.Topla(4, 5, out int toplamsonucu);

            Console.WriteLine(toplamsonucu);

            //Metot aşırı yükleme/ metot overloading

            int deger = 988;
            instance.EkranaYazdir(Convert.ToString(deger));
            instance.EkranaYazdir(deger);
            instance.EkranaYazdir("Halil", "Özdemir");

            Console.ReadLine();
        }
    }
    class metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;

        }
        public void EkranaYazdir(string a)
        {
            Console.WriteLine(a);
        }
        public void EkranaYazdir(int a)
        {
            Console.WriteLine(a);
        }

        public void EkranaYazdir(string a, string b)
        {
            Console.WriteLine(a + b);
        }

    }
}