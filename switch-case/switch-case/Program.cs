using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;


            for (int a = 0; a < 5; a++)
            {
                // Döngünün beşkere dönmesini sağlayan döngü.
                // a bir tamsayı ve 0 değerine eşit. 
                // Döngü a, 5'den küçük olduğu sürece döngü tekrar edecek. 
                // a sayısı her tekrarda 1 arttırılacak.

                for (int b = 0; b <= a; b++)
                {
                    // Kaçıncı satır ise o kadar dönen döngü.
                    // Örneğin : ikinci satırda ikikere dönecek.
                    // b bir tamsayı ve 0 değerine eşit. 
                    // Döngü b, a'ya eşit ya da a'dan küçük olduğu sürece döngü tekrar edecek. 
                    // b sayısı her tekrarda 1 arttırılacak.

                    Console.Write("*");
                    // Ekrana " * " işareti yazdırılacak.

                }
                Console.Write("\n");
                // Yeni bir satıra geçilecek

            }









            switch (month)

            {

                case 1:
                    Console.WriteLine("Ocak Ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayındasınız");
                    break;
                case 12:
                    Console.WriteLine("Aralık Ayındasınız");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi");
                    break;

            }


            switch (month)
            {

                case 1:
                case 12:
                case 2:

                    Console.WriteLine("Kış ayındasınız");
                    break;
                case 3:
                case 4:
                case 5:

                    Console.WriteLine("İlkbahar ayındasınız");
                    break;
                case 6:
                case 7:
                case 8:

                    Console.WriteLine("Yaz ayındasınız");
                    break;
                case 9:
                case 10:
                case 11:

                    Console.WriteLine("Sonbahar ayındasınız");
                    break;

                default:
                    break;

            }
        }
    }
} 