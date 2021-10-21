using System;
using System.Data;
using System.Data.Common;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAD - Tip Ad = Değer
            //Tam sayı değişken tipleri
            // camelCase PascalCase
            // degisken ne için kullanılıyorsa onu ifade edecek şekilde isimlenidirin
            /*
             * degiskenler sayi ile başlayamaz
             * _ harici hiçbir özel karakteri kullanamazsınız
             * boşluk kullanamazsınız
             * özel anahtar kelimeleri kullanamazsınız
             * büyükharf-küçük harf duyarlıdır.
             *
             */


            byte degiskenByte = 0;
            degiskenByte = Byte.MaxValue;
            degiskenByte = byte.MinValue;

            short degiskenShort = 153;
            degiskenShort = Int16.MaxValue;
            degiskenShort = short.MinValue;

            int degiskenInt = int.MaxValue;

            long degiskenLong = long.MaxValue;

            // ushort uint ulong

            // implicity convert

            short sayi = 32;

            int sayi2 = 32;

            sayi = Convert.ToInt16(sayi2);
            sayi = (short)sayi2;

            //ondalıklı sayılar
            double degiskenDouble = Double.MinValue;
            float degiskenFloat = float.MaxValue;
            decimal degiskenDecimal = decimal.MaxValue;

            degiskenDouble = 3.14d;
            degiskenFloat = 3.14F;
            degiskenDecimal = 3.14m;

            double sonuc = 7 / 2d;
            Console.WriteLine(sonuc);

            // string kelime

            char karakter = 'a';

            string kelime = "Merhaba Dünya";

            char harf = kelime[5];

            Console.WriteLine();

            //mantıksal değişken tipi

            bool isActive = true;

            isActive = !(degiskenShort == degiskenInt & degiskenDouble != 3.14);

            isActive = !isActive;

            /*
             * > < >= <= == != ! & |
             */

            DateTime tarih = DateTime.UtcNow;
            DayOfWeek haftaninGunu = tarih.DayOfWeek;

            Console.WriteLine(tarih);

            object obj = degiskenShort;
            obj = degiskenDouble;
            obj = kelime;
            obj = karakter;
            obj = haftaninGunu;
            obj = tarih;
        }
    }
}