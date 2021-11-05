using System.IO;

namespace Cs.Lib.Abstracts
{
    public abstract class YakinSaldiri : Silah, IVurulabilir
    {
        protected int _vurusKatsayisi;
        protected Stream _bicakCikarma, _bicakSaplama;
        public int VurusKatsayisi => _vurusKatsayisi;
        public Stream BicakSaplama => _bicakSaplama;

        public Stream BicakCıkarma => _bicakCikarma;

        public abstract int Vur();
    }
}