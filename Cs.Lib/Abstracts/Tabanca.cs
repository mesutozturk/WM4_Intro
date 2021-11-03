using System.IO;

namespace Cs.Lib.Abstracts
{
    public abstract class Tabanca : Silah, IAtesEdebilen, ISarjorlu
    {
        protected int _sarjorKapasitesi, _kalanFisek;
        protected Stream _atisSesi, _bitikFisekSesi,_yenidenDoldurmaSesi;

        public int SarjorKapasitesi => _sarjorKapasitesi; // readonly prop
        public int KalanFisek => _kalanFisek;
        public Stream AtisSesi => _atisSesi;
        public Stream BitikFisekSesi => _bitikFisekSesi;
        public Stream YenidenDoldurmaSesi => _yenidenDoldurmaSesi;
        public abstract int AtesEt();
        public abstract int YenidenDoldur();
    }
}
