using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiEnvanter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Kisi> kisiler = new List<Kisi>();

        private void ListeyiDoldur()
        {
            lstKisiler.Items.Clear();
            foreach (Kisi kisi in kisiler)
            {
                lstKisiler.Items.Add(kisi);
            }
        }
        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir fotoğraf seçiniz";
            dialog.Filter = "Resim Dosyaları | *.jpeg; *.jpg";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbResim.ImageLocation = dialog.FileName;
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                DogumTarihi = dtpDogumTarihi.Value,
                Telefon = txtTelefon.Text
            };
            MemoryStream resimStream = new MemoryStream();
            pbResim.Image.Save(resimStream, ImageFormat.Jpeg);

            yeniKisi.Fotograf = resimStream.ToArray();
            kisiler.Add(yeniKisi);
            ListeyiDoldur();
        }
    }
}
