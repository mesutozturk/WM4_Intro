using System;

namespace Kalitim
{
    public class Kare : Sekil
    {
        public Kare(double x)
        {
            this.X = x;
        }

        public Kare()
        {

        }

        public override double AlanHesapla()
        {
            return X * X;
        }
    }
}
