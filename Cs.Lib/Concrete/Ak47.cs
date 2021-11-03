using System.IO;
using System.Threading;
using Cs.Lib.Abstracts;

namespace Cs.Lib.Concrete
{
    public sealed class Ak47 : Tufek
    {
        public Ak47()
        {
            this._atisKatsayisi = 250;
            this._sarjorKapasitesi = 30;
            this._kalanFisek = this._sarjorKapasitesi;
            this.Fiyat = 2700;
            this.Hasar = 55;
            this.SilahResim = new MemoryStream(Properties.Resources.Ak47);
            this.Ulke = "Rusya";
            this._atisSesi = Properties.Resources.Ak47_Ates;
            this._bitikFisekSesi = Properties.Resources.Bitik_Mermi_Sesi;
            this._yenidenDoldurmaSesi = Properties.Resources.Ak47_Reload;
        }

        public override int AtesEt()
        {
            if (KalanFisek != 0)
            {
                this._kalanFisek--;
            }
            return this._kalanFisek;
        }

        public override int YenidenDoldur()
        {
            this._kalanFisek = this.SarjorKapasitesi;
            Thread.Sleep(1200);
            return KalanFisek;
        }
    }
}
