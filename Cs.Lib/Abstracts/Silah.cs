using System.IO;

namespace Cs.Lib.Abstracts
{
    public abstract class Silah
    {
        public string Ulke { get; protected set; }
        public decimal Fiyat { get; protected set; }
        public int Hasar { get; protected set; }
        public Stream SilahResim { get; protected set; }
    }
    public enum Silahlar : byte
    {
        Bıçak,
        USP,
        Glock,
        DesertEagle,
        AK47,
        M4A1S,
        AWP,
        ElBombası,
        FlashBombası
    }
}
