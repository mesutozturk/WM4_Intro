using System.IO;

namespace Cs.Lib.Abstracts
{
    public abstract class Firlatilan : Silah, IFirlatilabilen
    {
        protected Stream _bomba;
        public Stream Bomba => _bomba;
        public abstract int Firlat();
    }
}