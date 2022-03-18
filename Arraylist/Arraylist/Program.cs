using System;
using System.Collections;
using System.Collections.Generic;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //liste.Add("ahmet");
            //liste.Add( "ök");
            //liste.Add(true);
            //liste.Add('A');

            //Console.WriteLine(liste[1]);

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("///////////// Add Range /////////////");
            //string[] renkler = { "kırmızı", "mavi" };
            List<int> sayilar = new List<int>() {1,2,3,4,5,6,7,8,9 };
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(  item);
            }

            //sort
            Console.WriteLine("************ sort *****************");
            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //binary search

            Console.WriteLine("++++++++++++++ binary search ++++++++++++++++");
            Console.WriteLine(liste.BinarySearch(9));

            // reverse
            Console.WriteLine("*********** reverse ************");
            liste.Reverse();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //clear

            Console.WriteLine("********** clear ************");
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


        }
    }
}
