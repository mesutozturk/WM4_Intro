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
using KafeAdisyon.Business;
using KafeAdisyon.Data;
using KafeAdisyon.Model;

namespace KafeAdisyon.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        public CafeContext Context { get; set; }
        private KategoriRepository _kategoriRepo;
        private IRepository<Urun> _urunRepo;
        private void MenuForm_Load(object sender, EventArgs e)
        {
            _kategoriRepo = new KategoriRepository
            {
                Context = Context
            };
            _urunRepo = new UrunRepository();
            lstKategori.DataSource = _kategoriRepo.GetAll();
        }

        private Kategori _seciliKategori;
        private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;

            _seciliKategori = lstKategori.SelectedItem as Kategori;
            lstUrunler.DataSource = _seciliKategori.Urunler;
        }

        private void pbKategori_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir fotoğraf seçiniz";
            dialog.Filter = "Resim Dosyaları | *.jpeg; *.jpg";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbKategori.ImageLocation = dialog.FileName;
            }
        }

        private void pbUrun_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir fotoğraf seçiniz";
            dialog.Filter = "Resim Dosyaları | *.jpeg; *.jpg";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbUrun.ImageLocation = dialog.FileName;
            }
        }

        private void btnKategoriKaydet_Click(object sender, EventArgs e)
        {
            Kategori yeniKategori = new Kategori()
            {
                Ad = txtKategoriAdi.Text
            };
            if (pbKategori.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbKategori.Image.Save(resimStream, ImageFormat.Jpeg);

                yeniKategori.Fotograf = resimStream.ToArray();
            }
            _kategoriRepo.Add(yeniKategori);
            lstKategori.DataSource = null;
            lstKategori.DataSource = _kategoriRepo.GetAll();
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            Urun yeniUrun = new Urun()
            {
                Ad = txtUrunAdi.Text,
                Fiyat = nFiyat.Value
            };
            if (pbUrun.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbUrun.Image.Save(resimStream, ImageFormat.Jpeg);

                yeniUrun.Fotograf = resimStream.ToArray();
            }

            _kategoriRepo.AddProduct(_seciliKategori, yeniUrun);
            lstUrunler.DataSource = null;
            lstUrunler.DataSource = _seciliKategori.Urunler;

        }
    }
}
