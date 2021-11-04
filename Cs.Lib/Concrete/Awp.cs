using Cs.Lib.Abstracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public sealed class Awp : Tufek
    {
        public Awp()
        {
            this._atisKatsayisi = 100;
            this._sarjorKapasitesi = 30;
            this.Ulke = "Viyana";
            this.Hasar = 24;
            this.Fiyat = 6700m;
            this._kalanFisek = this.SarjorKapasitesi;
            this.SilahResim = new MemoryStream(Properties.Resources.AWP);
            this._atisSesi = Properties.Resources.AWP_Ates;
            this._yenidenDoldurmaSesi = Properties.Resources.Ak47_Reload;
        }
        public override int AtesEt()
        {
            if (KalanFisek != 0)
            {
                this._kalanFisek--;
            }
            Thread.Sleep(300);
            return this._kalanFisek;
        }

        public override int YenidenDoldur()
        {
            this._kalanFisek = this.SarjorKapasitesi;
            Thread.Sleep(1000);
            return KalanFisek;
        }
    }
}
