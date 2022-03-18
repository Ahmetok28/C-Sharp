using System;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = Convert.ToInt32(Console.ReadLine().Trim());
            int mod = deger % 2;
            if (mod == 0)
            {
                Console.WriteLine("Not Weird");
            }
            else
            {
                Console.WriteLine(" Weird");
            }
        }
    }
}
