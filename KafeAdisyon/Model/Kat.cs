using System.Collections.Generic;

namespace KafeAdisyon.Model
{
    public class Kat : CafeBase
    {
        public string Ad { get; set; }
        public int Sira { get; set; }
        public string Kod { get; set; }
        public List<Masa> Masalar { get; set; } = new List<Masa>();
        public override string ToString()
        {
            return $"{Ad} - {Masalar.Count}";
        }
    }
}