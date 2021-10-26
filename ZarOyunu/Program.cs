using System;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            do//1 oyunluk döngü
            {
                Random rnd = new Random();
                int[] zar = new int[2];
                int giris = 0, sayac = 0;
                Console.Write("Lütfen istediğiniz çiftin zar numarasını giriniz: ");
                do//sayıyı girebilene kadar dönen döngü
                {
                    try
                    {
                        giris = int.Parse(Console.ReadLine());
                        if (giris < 1 || giris > 6)
                            throw new Exception();
                        break;
                    }
                    catch
                    {
                        Console.Beep(500, 250);
                        Console.WriteLine("Hatalı Giriş!!!");
                        Console.WriteLine("1-6 arasında bir değer girmen gerekiyor");
                    }

                } while (true);
                do // bulana kadar dönen döngü
                {
                    zar[0] = rnd.Next(1, 7);
                    zar[1] = rnd.Next(1, 7);
                    sayac++;
                    Console.WriteLine(string.Format("{0}. {1}-{2}", sayac, zar[0], zar[1]));
                    if (zar[0] == zar[1] && zar[0] == giris)
                    {
                        Console.WriteLine(string.Format("{0}. denemede bulundu", sayac));
                        break;
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
