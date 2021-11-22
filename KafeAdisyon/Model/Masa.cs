namespace KafeAdisyon.Model
{
    public class Masa : CafeBase
    {
        public string Ad { get; set; }
        public int Sira { get; set; }
        public MasaDurumlar MasaDurumu { get; set; }

        public override string ToString()
        {
            return $"{Sira}-{Ad}";
        }
    }
}