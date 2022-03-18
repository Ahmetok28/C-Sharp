using System;

namespace For_Dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {

                    if (j >= i)
                    {
                        Console.WriteLine("#");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }
                }
                Console.WriteLine("");
            }





            Console.Write("Sayı Giriniz: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }


          

            int oddTotal = 0;
            int evenTotal = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    oddTotal += i;
                }
                else
                    evenTotal += i;
            }

            Console.WriteLine("Tek Sayıların Toplamı: " + oddTotal);
            Console.WriteLine("Çift Sayıların Toplamı: " + evenTotal);


            

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
