using System;
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
            //try
            //{
            //    kisi.Ad = "Kamil";
            //    kisi.Soyad = "³Fıdıl";
            //    kisi.DogumTarihi = new DateTime(1985, 5, 20);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            //} // set
            //MessageBox.Show($"Kişinin yaşı: {kisi.Yas}"); //get
        }
    }
}
