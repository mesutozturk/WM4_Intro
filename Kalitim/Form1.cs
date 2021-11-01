using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sekil k1 = new Kare(10);
            Sekil k2 = new Kare(5);
            Sekil d1 = new Dikdortgen(3, 4);
            Sekil d2 = new Dikdortgen(5, 12);
            Sekil da1 = new Daire(7);
            Sekil da2 = new Daire(8);
            Sekil u1 = new DikUcgen(6, 8);
            Sekil u2 = new DikUcgen(10, 24);

            lstSekiller.Items.Add(k1);
            lstSekiller.Items.Add(k2);
            lstSekiller.Items.Add(d1);
            lstSekiller.Items.Add(d2);
            lstSekiller.Items.Add(da1);
            lstSekiller.Items.Add(da2);
            lstSekiller.Items.Add(u1);
            lstSekiller.Items.Add(u2);
        }

        private void lstSekiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSekiller.SelectedItem == null) return;

            //Sekil seciliSekil = lstSekiller.SelectedItem as Sekil;
            Sekil seciliSekil = (Sekil)lstSekiller.SelectedItem;

            if (seciliSekil is Kare)
            {

            }
            else if (seciliSekil is Dikdortgen)
            {
                Dikdortgen dd = seciliSekil as Dikdortgen;
                
            }
            else if (seciliSekil is Daire dd)
            {
                this.Text = dd.Cap().ToString();
            }

            lblDetay.Text =
                $"Alanı: {seciliSekil.AlanHesapla()}\nÇevresi: {seciliSekil.CevreHesapla()}\nKöşegen Uzunluğu:{seciliSekil.KosegenHesapla()}";
        }
    }
}
