using System;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            do//1 oyunluk döngü
            {
                Random rnd = new Random();
                int tahminSayisi = 0, rastgeleSayi = rnd.Next(1, 101), giris = 0;
                do
                {
                    Console.Write("Rastgele sayımı tahmin et: ");
                    try
                    {
                        giris = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Yanlış bir ifade girdiniz");
                        continue;
                    }
                    finally
                    {
                        tahminSayisi++;
                    }

                    if (giris == rastgeleSayi)
                    {
                        Console.WriteLine("Tebrikler " + tahminSayisi + ". Denemede Bildiniz");
                        break;
                    }
                    else if (giris > rastgeleSayi)
                    {
                        Console.WriteLine("Tahminizi Düşürün");
                    }
                    else
                    {
                        Console.WriteLine("Tahminizi Arttırın");
                    }
                } while (true);

                Console.WriteLine("Tekrar oynamak için E tuşuna basınız");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.E)
                    break;
            } while (true);
        }
    }
}
