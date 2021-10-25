using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays - Diziler
            //Aynı tipten birden fazla değeri tutabildiğimiz veri tiplerine dizi adını veriyoruz.
            //Index 0dan başlar

            int sayi = 0;

            int[] sayilar = new[] { 3, 5, 6, 69, 45, 41, 1 };
            sayilar = new int[10];

            sayilar[0] = 3;
            sayilar[1] = 5;
            sayilar[2] = 6;
            sayilar[3] = 69;

            Console.WriteLine(sayilar.Length);

            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(100);
            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(sayilar[i]);
            }

            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }

            double[,] matris = new double[5, 3];

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rnd.NextDouble() * rnd.Next(100);
                }
            }

            Array.Resize(ref sayilar, 20);


        }
    }
}
