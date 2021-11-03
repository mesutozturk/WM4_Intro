using System.IO;

namespace Cs.Lib.Abstracts
{
    public abstract class Tufek : Silah, ISarjorlu, IAtesEdebilen, ISeriAtabilir
    {
        protected int _sarjorKapasitesi, _kalanFisek, _atisKatsayisi;
        protected Stream _atisSesi, _bitikFisekSesi, _yenidenDoldurmaSesi;

        public int AtisKatsayisi => _atisKatsayisi;
        public int SarjorKapasitesi => _sarjorKapasitesi; // readonly prop
        public int KalanFisek => _kalanFisek;
        public Stream AtisSesi => _atisSesi;
        public Stream BitikFisekSesi => _bitikFisekSesi;
        public Stream YenidenDoldurmaSesi => _yenidenDoldurmaSesi;
        public abstract int AtesEt();
        public abstract int YenidenDoldur();
    }
}