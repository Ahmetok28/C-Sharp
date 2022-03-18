using System;
using System.Collections;

namespace Koleksiyonlar_Odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            Console.WriteLine("Lüften 20 Adet Pozitif Tam Sayı Giriniz:");
            for (int i = 1; i <= 20;)
            {

                try
                {
                    Console.WriteLine("Lütfen " + i + ". Sayıyı Giriniz:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    liste.Add(n);
                    i++;

                }
                catch (Exception)
                {

                    Console.WriteLine("Lüften Harf girmeyiniz!");
                
                }   
            }
            liste.Sort();
            double enKucukUc=0;
            double enBuyukUc = 0;
            for (int i = 0; i < 3; i++)
            {                
                enKucukUc += Convert.ToInt32(liste[i]);
            }
            
            for (int i = 19; 16 < i; i--)
            {              
                enBuyukUc += Convert.ToInt32(liste[i]);
            }

            double eKUcOrt = enKucukUc/3;
            double eBUcOrt = enBuyukUc/3;

            Console.WriteLine("En küçük üç tanesinin ortalamsı: "+eKUcOrt);
            Console.WriteLine("En küçük üç tanesinin ortalamsı: "+eBUcOrt);
            Console.WriteLine("Ortalamalrın toplamları: "+(eBUcOrt+eKUcOrt));





        }
    }
}
