using System.Collections.Generic;

namespace KafeAdisyon.Model
{
    public class Kategori : CafeBase
    {
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public byte[] Fotograf { get; set; }
        public List<Urun> Urunler { get; set; } = new List<Urun>();
        public override string ToString()
        {
            return Ad;
        }
    }
}
