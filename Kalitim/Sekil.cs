using System;

namespace Kalitim
{
    public abstract class Sekil
    {
        public double X { get; set; }

        public abstract double AlanHesapla();

        public virtual double CevreHesapla()
        {
            return 4 * X;
        }

        public virtual double KosegenHesapla()
        {
            return Math.Sqrt(2) * X;
        }
    }
}
