using KafeAdisyon.Model;

namespace KafeAdisyon.ViewModels
{
    public class SiparisViewModel
    {
        public int Adet { get; set; } = 1;
        public decimal BirimFiyat { get; set; }
        public decimal AraToplam { get { return Adet * BirimFiyat; } }
        public Urun Urun { get; set; }
    }
}
