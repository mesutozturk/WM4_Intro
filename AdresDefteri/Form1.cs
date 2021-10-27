using System.Windows.Forms;
using AdresDefteri.Models;

namespace AdresDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kisi kisi = new Kisi();
        Ders ders = new Ders();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            kisi.ad = "Kamil";
            kisi.soyad = "234092384"; // set
            MessageBox.Show(kisi.soyad); //get
        }
    }
}
