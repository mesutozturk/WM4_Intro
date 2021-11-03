namespace Cs.Lib.Abstracts
{
    public abstract class Tabanca : Silah, IAtesEdebilen, ISarjorlu
    {
        protected int _sarjorKapasitesi, _kalanFisek;

        public int SarjorKapasitesi => _sarjorKapasitesi; // readonly prop
        public int KalanFisek => _kalanFisek;
        public abstract int AtesEt();
        public abstract int YenidenDoldur();
    }
}
