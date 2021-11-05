using System;

namespace KisiEnvanter
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public DateTime DogumTarihi { get; set; }
        public byte[] Fotograf { get; set; }

        public override string ToString() => $"{Ad} {Soyad}";
    }
}