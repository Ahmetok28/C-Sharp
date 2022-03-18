using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            byte b = 5;
            sbyte s = 5;
            short sh = 5;
            ushort us = 5;
            Int16 i16 = 16;
            int i = 1;
            Int32 i32 = 32;
            Int64 i64 = 64;
            uint ui = 2;
            long l = 5;
            ulong ul = 2;

            //Reel Sayılar//
            float fl = 5;
            double d = 5;
            decimal dc = 5;


            string str = "6dsdcsdcsdvesc;";

            bool tr = true;
            bool fal = false;

            DateTime dt = DateTime.Today;

            Console.WriteLine(str);


            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);


            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);


            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM.yyyy");
            Console.WriteLine(dateTime2);
        }
    }
}
