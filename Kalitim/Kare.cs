namespace Kalitim
{
    public class Kare : Sekil
    {
        public Kare(double x) : base(x)
        {

        }

        //public Kare()
        //{

        //}

        public override double AlanHesapla()
        {
            return X * X;
        }

        public override string ToString()
        {
            return "Kare " + AlanHesapla() + "br²";
        }
    }
}
