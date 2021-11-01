using System;

namespace Kalitim
{
    public class Dikdortgen
    {
        public Dikdortgen(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Dikdortgen()
        {

        }
        public double X { get; set; }
        public double Y { get; set; }

        public double AlanHesapla()
        {
            return X * Y;
        }

        public double CevreHesapla()
        {
            return 2 * (X + Y);
        }

        public double KosegenHesapla()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
    }
}
