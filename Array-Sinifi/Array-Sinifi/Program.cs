using System;

namespace Array_Sinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personeller = new string[0];

            bool durum = true;
            while (durum)
            {
                Console.WriteLine("1.Personel Ekle\n##########\n2.Personelleri Görüntüle\n##########\n3.Çıkış");
                char secim = Console.ReadKey(true).KeyChar;

                switch (secim)
                {
                    case '1':
                        Array.Resize(ref personeller, personeller.Length + 1);
                        Console.Write("Personel adı: ");
                        string ad = Console.ReadLine();
                        Console.Write("Personel soyadı: ");
                        string soyad = Console.ReadLine();
                        personeller[personeller.Length - 1] = ad + " " + soyad;
                        break;
                    case '2':
                        Console.WriteLine("##########PERSONEL LİSTESİ##########");
                        for (int i = 0; i < personeller.Length; i++)
                        {
                            Console.WriteLine((i + 1) + "." + personeller[i]);
                        }
                        Console.WriteLine("##########");
                        break;
                    case '3':
                        durum = false;
                        break;
                    default:
                        Console.WriteLine("Lütfen geçerli bir seçim yapınız");
                        break;
                }
            }
        }
    }
}
