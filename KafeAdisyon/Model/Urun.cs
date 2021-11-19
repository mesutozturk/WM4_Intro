namespace KafeAdisyon.Model
{
    public class Urun : CafeBase
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public byte[] Fotograf { get; set; }
    }
}