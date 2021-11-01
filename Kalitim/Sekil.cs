using System;

namespace Kalitim
{
    public class Sekil
    {
        public double X { get; set; }

        public double AlanHesapla()
        {
            return X * X;
        }

        public double CevreHesapla()
        {
            return 4 * X;
        }

        public double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}
