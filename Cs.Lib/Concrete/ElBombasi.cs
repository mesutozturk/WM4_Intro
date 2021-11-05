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
    public sealed class ElBombasi : Firlatilan
    {
        public ElBombasi()
        {
            this.Fiyat = 350;
            this.Hasar = 80;
            this.Ulke = "Türkiye";
            this.SilahResim = new MemoryStream(Properties.Resources.Bomba);
        }
        public override int Firlat()
        {
            this._bomba = Properties.Resources.Bomb;
            Thread.Sleep(500);
            return Hasar;
        }
    }
}
