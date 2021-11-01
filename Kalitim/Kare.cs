using System;

namespace Kalitim
{
    public class Kare
    {
        public Kare(double x)
        {
            this.X = x;
        }

        public Kare()
        {

        }
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
            return X * Math.Sqrt(2);
        }
    }
}
