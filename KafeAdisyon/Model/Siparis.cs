namespace KafeAdisyon.Model
{
    public class Siparis : CafeBase
    {
        public Urun Urun { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
    }
}