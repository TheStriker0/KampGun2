﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"Yazılım GEliştirici Kampı", "Programlamaya Giriş", "Java", "Python" };

            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for BİTtİİ");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
        }
    }
}
