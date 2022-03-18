using System;

namespace DateTime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));


            Console.WriteLine(DateTime.Now.ToString("dd"));//11
            Console.WriteLine(DateTime.Now.ToString("ddd"));//pzt/mon
            Console.WriteLine(DateTime.Now.ToString("dddd"));//pazartesi / monday

            Console.WriteLine(DateTime.Now.ToString("MM"));//10
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Eki
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//Ekim

            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021
            Console.WriteLine("############## Math Kütüphanesi ##############");
            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));//mutlak değer
            Console.WriteLine(Math.Sin(10));//sinus
            Console.WriteLine(Math.Cos(10));//cosinus
            Console.WriteLine(Math.Tan(10));//tanjant

            Console.WriteLine(Math.Ceiling(22.3));//yukarı yuvarlar
            Console.WriteLine(Math.Round(22.3));//yakın sayıya yuvarlama
            Console.WriteLine(Math.Round(22.7));
            Console.WriteLine(Math.Floor(22.7));//aşağı yuvarlar

            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));

            Console.WriteLine(Math.Pow(3, 4));//üstte olan sayıyı döndürür
            Console.WriteLine(Math.Sqrt(9));///karesini alır
            Console.WriteLine(Math.Log(9));//logaritma
            Console.WriteLine(Math.Exp(3));//üstel fonksiyon //--e üzeri x--
            Console.WriteLine(Math.Log10(10));
        }
    }
}
