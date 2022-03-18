
using System;

namespace CatalanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BracketCombinations(9));
        }
        public static double faktoriyel(int gelen)
        {
            double faktoriyel = 1;
            for (int i = 1; i <= gelen; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine(faktoriyel);
            return faktoriyel;
           
        }

        public static double BracketCombinations(int num)
        {
            double Combinations = faktoriyel(2 * num) / ((faktoriyel(num + 1)) * faktoriyel(num));
            return Combinations; 
        }
    }
}
