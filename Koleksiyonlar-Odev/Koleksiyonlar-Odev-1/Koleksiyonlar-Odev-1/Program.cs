using System;
using System.Collections;

namespace Koleksiyonlar_Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asallar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();

            Console.WriteLine("Lüften 20 Adet Pozitif Tam Sayı Giriniz:");
            for (int i = 1; i <= 20;)
            {
                try
                {
                    Console.WriteLine("Lütfen " + i + ". Sayıyı Giriniz:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n > 0)
                    {
                        if (Asalmi(n))
                        {
                            asallar.Add(n);
                            i++;
                        }
                        else
                        {
                            asalOlmayanlar.Add(n);
                            i++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lüften Negatif sayı ve harf girmeyiniz!");
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Lüften Negatif sayı ve harf girmeyiniz!");
                }


            }

            asalOlmayanlar.Sort();
            asallar.Sort();
            asalOlmayanlar.Reverse();
            asallar.Reverse();
            int asallarToplami = 0;
            int asalOlmayanlarToplami = 0;
            Console.WriteLine("Asal Sayılar: ");
            foreach (var item in asallar)
            {
                asallarToplami += Convert.ToInt32(item);
                Console.Write(item + " ");
            }
            Console.WriteLine("\nAsal Olmayan Sayılar: ");
            foreach (var item in asalOlmayanlar)
            {
                asalOlmayanlarToplami += Convert.ToInt32(item);
                Console.Write(item + " ");
            }
            int asl = asallar.Count;
            Console.WriteLine("\nAsal Sayılar: " + asl + " tane \n" + "Ortalaması : " + asallarToplami / asl);
            int aslOlmy = asalOlmayanlar.Count;
            Console.WriteLine("Asal Olmayan Sayılar: " + aslOlmy + " tane \n" + "Ortalaması : " + asalOlmayanlarToplami / aslOlmy);
        }

        public static bool Asalmi(int sayi)
        {
            bool durum = false;
            int kontrol = 0;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }

            return durum;
        }
    }
}
