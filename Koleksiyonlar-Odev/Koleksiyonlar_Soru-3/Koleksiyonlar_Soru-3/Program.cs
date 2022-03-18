using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            Console.Write("Lütfen cümlenizi giriniz: ");
            string girilenMetin = Console.ReadLine();
            string sesliHarfler = "aeıioöuüAEIİOÖUÜ";
            int sayac = 0;
            for (int i = 0; i < girilenMetin.Length; i++)
            {
                if (sesliHarfler.Contains(girilenMetin[i]))
                {
                    sayac++;
                    liste.Add(girilenMetin[i]);
                }


            }

            Console.WriteLine("Cümlenin içinde toplam " + sayac + " tane sesli harf var.");
            Console.WriteLine("Cümledeki sesli harfer:");
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
