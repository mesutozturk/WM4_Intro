namespace Kalitim
{
    public class DikUcgen : Dikdortgen
    {
        public DikUcgen(double x, double y) : base(x, y)
        {
        }
        public override double AlanHesapla()
        {
            return base.AlanHesapla() / 2;
        }

        public override double CevreHesapla()
        {
            return base.CevreHesapla() / 2 + base.KosegenHesapla();
        }
        public override string ToString()
        {
            return "DikÜçgen " + AlanHesapla() + "br²";
        }
    }
}
