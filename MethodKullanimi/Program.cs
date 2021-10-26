using System;

namespace MethodKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method

            //geriye değer dönecek mi? hayır ise void evet ise hangi tip olacaksa o tipi yazmalıyız
            //eğer geriye dönüş tipi yazıldıysa, geriye dönecek ifade return keywordu ile döndürülecektir.
            //bu metoda isim vermeliyiz. PascalCase
            //bu metod çalışırken parametreye ihtiyacı var mı? hayır ise boş bırakılacak. evet ise her parametre tek tek tanımlanacaktır.

            Console.WriteLine();
            double alan = AlanHesapla(5);
            alan = AlanHesapla(3, 4);
            alan = AlanHesapla(5d);
            int sonuc = Topla(Topla(3, 5), 5) + Topla(9, 7);
            int[] sayilar = { 3, 5, 6, 5, 8, 7, 4, 5, 5, 9, 8, 7, 7, 8, 32, 5, 5 };
            sonuc = Topla(new[] { 3, 5, 6, 5, 8, 7, 4, 5, 5, 9, 8, 7, 7, 8, 32, 5, 5 }, 1);
            sonuc = Topla(sayilar, 1);
            sonuc = Topla(3, 5, 6, 5, 8, 7, 4, 5, 5, 9, 8, 7, 7, 8, 32, 5, 5);
            Console.WriteLine(sonuc);
            
        }
        /// <summary>
        /// Karenin alanını hesaplayan metod.
        /// </summary>
        /// <param name="kenar">Karenin 1 kenarının uzunluğu</param>
        /// <returns>Karenin alanı</returns>
        static double AlanHesapla(int kenar)
        {
            double sonuc = kenar * kenar;
            return sonuc;
        }
        /// <summary>
        /// Dikdörtgenin alanın hesaplanmasın kullanılır
        /// </summary>
        /// <param name="kenar1">kenar1 </param>
        /// <param name="kenar2">kenar2 </param>
        /// <returns>Dikdörtgenin alanı</returns>
        static double AlanHesapla(int kenar1, int kenar2)
        {
            return kenar1 * kenar2;
        }
        /// <summary>
        /// Çemberin alanını hesaplayan method
        /// </summary>
        /// <param name="r">yarıçap</param>
        /// <param name="pi">Pi sayısı</param>
        /// <returns></returns>
        static double AlanHesapla(double r, double pi = Math.PI)
        {
            return r * r * pi;
        }

        static int Topla(int a, int b)
        {
            return a + b;
        }

        static int Topla(int[] sayilar, int yuvarlama)
        {
            int sonuc = 0;
            foreach (int sayi in sayilar)
            {
                sonuc += sayi;
            }
            return sonuc;
        }
        static int Topla(double yuvarlama, params int[] sayilar)
        {
            int sonuc = 0;
            foreach (int sayi in sayilar)
            {
                sonuc += sayi;
            }
            return sonuc;
        }
    }
}
