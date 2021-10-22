using System;

namespace KararYapilariVeDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // if 
            bool isActive = true;
            if (isActive)
            {
                Console.WriteLine("Program aktif");
            }
            else
            {
                Console.WriteLine("Program Pasif");
            }

            if (true) Console.WriteLine("1");
            else Console.WriteLine("2");

            //if if-else else
            int ortalama = 60;

            if (ortalama >= 50)
            {
                Console.WriteLine("Geçtiniz");
            }
            else if (ortalama >= 40)
            {
                Console.WriteLine("Şartlı geçtiniz");
            }
            else
            {
                Console.WriteLine("Kaldınız");
            }

            //ternary if 

            string sonuc = "";

            if (ortalama > 50)
                sonuc = "Geçtiniz";
            else
                sonuc = "Kaldınız";

            // degisken = ifade ? true olduğunda yapılacak : false olduğunda yapılacak

            sonuc = ortalama > 50 ? "Geçtiniz" : "Kaldınız";

            DateTime tarih = DateTime.Now;
            if (tarih.DayOfWeek == DayOfWeek.Sunday)
            {
                sonuc = "Pazar";
            }
            else if (tarih.DayOfWeek == DayOfWeek.Monday)
            {
                sonuc = "Pazartesi";
            }
            else if (tarih.DayOfWeek == DayOfWeek.Tuesday)
            {
                sonuc = "Salı";
            }
            else if (tarih.DayOfWeek == DayOfWeek.Wednesday)
            {
                sonuc = "Çarşamba";
            }

            switch (sonuc)
            {
                case "Pazartesi":
                    Console.WriteLine("Pazartesi");
                    break;
                case "Salı":
                    Console.WriteLine("Salı");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            DayOfWeek haftaninGunu = tarih.DayOfWeek;
            switch (haftaninGunu)
            {
                case DayOfWeek.Sunday:
                    sonuc = "Pazar";
                    break;
                case DayOfWeek.Monday:
                    sonuc = "Pazartesi";
                    break;
                case DayOfWeek.Tuesday:
                    sonuc = "Salı";
                    break;
                case DayOfWeek.Wednesday:
                    sonuc = "Çarşamba";
                    break;
                case DayOfWeek.Thursday:
                    sonuc = "Perşembe";
                    break;
                case DayOfWeek.Friday:
                    sonuc = "Cuma";
                    break;
                default:
                    sonuc = "Cumartesi";
                    break;
            }
            //donguler
            //while
            int sayac = 0, gunSayisi = 0;
            while (gunSayisi < 100)
            {
                DateTime sonraki = tarih.AddDays(sayac);
                sayac++;
                if (sonraki.DayOfWeek == DayOfWeek.Saturday || sonraki.DayOfWeek == DayOfWeek.Sunday)
                    continue;
                Console.WriteLine(sonraki);
                gunSayisi++;
            }
            Console.Clear();
            sayac = 0; gunSayisi = 0;
            do
            {
                DateTime sonraki = tarih.AddDays(sayac);
                sayac++;
                if (sonraki.DayOfWeek == DayOfWeek.Saturday || sonraki.DayOfWeek == DayOfWeek.Sunday)
                    continue;
                Console.WriteLine(sonraki);
                gunSayisi++;
            } while (gunSayisi < 100);

            // break continue return

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}