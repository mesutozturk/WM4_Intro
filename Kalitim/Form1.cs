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
            Kare k1 = new Kare(10);
            k1.X = 10;
            double kareAlani = k1.AlanHesapla();
            //MessageBox.Show("Karenin alanı: " + kareAlani);

            Dikdortgen d1 = new Dikdortgen(3, 4);
            double dikdortgenAlani = d1.AlanHesapla();
            MessageBox.Show("Dikdörtgenin alanı: " + dikdortgenAlani);

            //Sekil sekil1 = new Sekil();
            //sekil1.X = 20;
            //double alan = sekil1.AlanHesapla();
        }
    }
}
