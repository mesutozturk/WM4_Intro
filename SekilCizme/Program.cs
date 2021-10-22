using System;

namespace SekilCizme
{
    class Program
    {
        static void Main(string[] args)
        {
            //disaridan girilen sayi kadar * karakteri kullanilarak kare sekli cizme
            /*
             * 5
             * *****
             * *****
             * *****
             * *****
             * *****
             * a) eger yanlis bir giris olduysa program tekrar bir sayi girmesi icin istekte bulunmali
             * b) cizim islemi bittikten sonra tekrar calistirmak istiyormusunuz? e/h diye bir soru sormali cevap e ise tekrar bastan baslamali
             * c) sekli ici bos cizsin
             *  4
             *  ****
             *  *  *
             *  *  *
             *  ****
             * d) girilen sayi yuksekliginde eskenar ucgen cizsin
             *  3 icin
             *    *
             *   ***
             *  *****
             * 4 icin
             *     *
             *    ***
             *   *****
             *  *******
             * f) giriste bana 3 farkli secenek sunsun. 1) kare 2) iciboskare 3)ucgen
             * bu secenekleri sectigimde ona gore cizim yapsin
             */
            do//1 tam döngü
            {
                Console.WriteLine("1: Kare");
                Console.WriteLine("2: İçiboş kare Kare");
                Console.WriteLine("3: Üçgen");
                Console.Write("Bir seçim yapınız... ");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.D1 || info.Key == ConsoleKey.NumPad1)
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Lütfen karenin kenar uzunluğunu giriniz");
                            int sayi = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            for (int satir = 0; satir < sayi; satir++)
                            {
                                for (int sutun = 0; sutun < sayi; sutun++)
                                {
                                    Console.Write("X");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Yanlış bir giriş yaptınız");
                        }
                    } while (true);
                }
                else if (info.Key == ConsoleKey.D2 || info.Key == ConsoleKey.NumPad2)
                {
                    //içiboş kare
                    do
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Lütfen karenin kenar uzunluğunu giriniz");
                            int sayi = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            for (int satir = 0; satir < sayi; satir++)
                            {
                                for (int sutun = 0; sutun < sayi; sutun++)
                                {
                                    if (satir == 0 || sutun == 0 || satir == sayi - 1 || sutun == sayi - 1)
                                        Console.Write("X");
                                    else
                                        Console.Write(" ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Yanlış bir giriş yaptınız");
                        }
                    } while (true);
                }
                else if (info.Key == ConsoleKey.D3 || info.Key == ConsoleKey.NumPad3)
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("Lütfen üçgenin yüksekliğini giriniz");
                            int sayi = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            for (int satir = 0; satir < sayi; satir++)
                            {
                                for (int sutun = 0; sutun < sayi + satir; sutun++) // n+0 n+1 n+2
                                {
                                    if (sayi > sutun + satir + 1) //n-2 n-1 n-0 
                                        Console.Write(" ");
                                    else
                                        Console.Write("X");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Yanlış bir giriş yaptınız");
                        }
                    } while (true);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Yanlış bir seçim yaptınız");
                    continue;
                }
                //tekrar oynamak istermisin?
                Console.WriteLine();
                Console.WriteLine("Tekrar çizim yapmak ister misin? E/H?");
                info = Console.ReadKey();
                if (info.Key != ConsoleKey.E)
                    break;

            } while (true);

            Console.WriteLine("Programı kapatabilirsiniz");
        }
    }
}