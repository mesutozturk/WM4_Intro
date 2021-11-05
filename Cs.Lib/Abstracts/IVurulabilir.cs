using System.IO;

namespace Cs.Lib.Abstracts
{
    public interface IVurulabilir
    {
        int VurusKatsayisi { get; }
        Stream BicakCıkarma { get; }
        Stream BicakSaplama { get; }
        int Vur();
    }
}