using System;
using System.Collections.Generic;
using System.Linq;

namespace Tanımlama_Erisim_ve_Dongulerle_Dizi_Kullanımı
{
    class Program
    {
       

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(arr);
        }

        private static void plusMinus(List<int> arr)
        {
                decimal pozitifler = 0;
                decimal negatifler = 0;
                decimal sifir = 0;


                foreach (int num in arr)
                {
                    if (num > 0)
                    {
                        pozitifler++;
                    }
                    else if (num < 0)
                    {
                        negatifler++;
                    }
                    else
                    {
                        sifir++;
                    }

                    Console.WriteLine(pozitifler / arr.Count());
                    Console.WriteLine(negatifler / arr.Count());
                    Console.WriteLine(sifir / arr.Count());
                }
            }
        }
    }

}
