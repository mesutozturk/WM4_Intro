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
    }
}
