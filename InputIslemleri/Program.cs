using System;

namespace InputIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Adınızı giriniz: ");
            //string ad = Console.ReadLine();
            //Console.WriteLine();

            /*
             * Kullanıcı girişleri
             * Veritabanı istekleri (CRUD)
             * Dosya işlemleri
             * Sunucu istekleri
             * Tür dönüşümleri
             *
             * Try - Catch | Error Handling
             */

            Console.Write("Lütfen 1 ile 100 arasında bir sayı giriniz: ");
            int girilenSayi = 0;
            try
            {
                girilenSayi = int.Parse(Console.ReadLine());
                if (girilenSayi < 1 || girilenSayi > 100)
                {
                    throw new Exception("Girilen sayı 1-100 arasında değil.");
                }

                Console.WriteLine(girilenSayi * girilenSayi);
            }
            catch (OverflowException ex1)
            {
                Console.WriteLine("Girilen sayı çok büyük ya da çok küçük");
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally çalıştı");
            }

            Console.WriteLine("1-6 arası bir sayı giriniz");
            int sayi2 = 0;
            string girilen = Console.ReadLine();
            if (int.TryParse(girilen, out sayi2))
            {
                
                Console.WriteLine(sayi2 * sayi2 * sayi2);
            }
            else
            {
                Console.WriteLine("Bir sayı girmeyi beceremedin");
            }
        }
    }
}
