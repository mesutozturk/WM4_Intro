using System;

namespace Kalitim
{
    public class Daire : Sekil
    {
        //public Daire()
        //{

        //}

        public Daire(double x) : base(x)
        {
        }

        public override double AlanHesapla()
        {
            return Math.Pow(X, 2) * Math.PI;
        }

        public override double CevreHesapla()
        {
            return 2 * Math.PI * X;
        }

        public override double KosegenHesapla()
        {
            return 2 * X;
        }

        public double Cap()
        {
            return 2 * X;
        }
        public override string ToString()
        {
            return "Daire " + Math.Round(AlanHesapla(), 2) + "br²";
        }
    }
}
