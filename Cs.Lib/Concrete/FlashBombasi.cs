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
    public sealed class FlashBombasi : Firlatilan
    {
        public FlashBombasi()
        {
            this.Fiyat = 550;
            this.Hasar = 80;
            this.Ulke = "İran";
            this.SilahResim = new MemoryStream(Properties.Resources.Flash);
        }
        public override int Firlat()
        {
            this._bomba = Properties.Resources.Flashbang;
            Thread.Sleep(500);
            return Hasar;
        }
    }
}
