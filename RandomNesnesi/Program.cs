using System;

namespace RandomNesnesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random rnd = new Random(); //instance

            //0-100 arası rastgele bir sayı 
            int sayi1 = rnd.Next(0, 100);
            sayi1 = rnd.Next(100);

            //-10 ile 20 arasında rastgele sayı
            int sayi2 = rnd.Next(-10, 20);

            //rastgele 1 int sayisi 
            int sayi3 = rnd.Next();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(rnd.Next(1,50));
            }
        }
    }
}
