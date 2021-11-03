namespace Cs.Lib.Abstracts
{
    public abstract class Tufek : Silah, ISarjorlu, IAtesEdebilen, ISeriAtabilir
    {
        protected int _sarjorKapasitesi, _kalanFisek, _atisKatsayisi;
        public int AtisKatsayisi => _atisKatsayisi;
        public int SarjorKapasitesi => _sarjorKapasitesi; // readonly prop
        public int KalanFisek => _kalanFisek;
        public abstract int AtesEt();
        public abstract int YenidenDoldur();
    }
}