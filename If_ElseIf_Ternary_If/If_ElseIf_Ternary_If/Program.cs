using System;

namespace If_ElseIf_Ternary_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time <= 11)
            {
                Console.WriteLine("Günyadın");
            }
            else if (time <= 18)
            {
                Console.WriteLine("İyi Günler");
            }
            else
            {
                Console.WriteLine("İyi Geceler");
                string sonuc = time <= 18 ? "İyi Günler" : "İyi Geceler";
                Console.WriteLine(sonuc);

                sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";


            }
        }
    }
}