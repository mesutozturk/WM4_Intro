using KafeAdisyon.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using KafeAdisyon.Business;
using KafeAdisyon.Data;
using System.Collections;

namespace KafeAdisyon.Forms
{
    public partial class SiparisForm : Form
    {
        public SiparisForm()
        {
            InitializeComponent();
        }
        public Masa SeciliMasa { get; set; }
        public List<Siparis> MasaninSiparisleri { get; set; }
        public CafeContext Context { get; set; }
        private KategoriRepository _kategoriRepository;
        private SiparisRepository _siparisRepository;

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            _kategoriRepository = new KategoriRepository() { Context = Context };
            _siparisRepository = new SiparisRepository() { Context = Context };
            List<Kategori> kategoriler = _kategoriRepository.GetAll(x => x.Urunler.Count > 0);
            flpKategori.Controls.Clear();
            foreach (Kategori kategori in kategoriler)
            {
                Button btn = new Button()
                {
                    Text = kategori.Ad,
                    Size = new Size(220, 150),
                    BackgroundImage = Image.FromStream(new MemoryStream(kategori.Fotograf)),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    ForeColor = Color.White,
                    Font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Regular),
                    Tag = kategori
                };
                btn.Click += KategoriBtn_Click; ;
                flpKategori.Controls.Add(btn);
            }
            lstSiparis.FullRowSelect = true;

            ListeyiDoldur();
        }
        private Kategori _seciliKategori;
        private void KategoriBtn_Click(object sender, EventArgs e)
        {
            Button seciliButton = sender as Button;

            _seciliKategori = seciliButton.Tag as Kategori;
            List<Urun> urunler = _seciliKategori.Urunler;
            flpUrun.Controls.Clear();
            foreach (Urun urun in urunler)
            {
                Button btn = new Button()
                {
                    Text = urun.Ad,
                    Size = new Size(220, 150),
                    BackgroundImage = Image.FromStream(new MemoryStream(urun.Fotograf)),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    ForeColor = Color.White,
                    Font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Regular),
                    Tag = urun
                };
                btn.Click += BtnUrun_Click; ;
                flpUrun.Controls.Add(btn);
            }
        }
        Urun _seciliUrun;
        private void BtnUrun_Click(object sender, EventArgs e)
        {
            Button seciliButton = (Button)sender;
            _seciliUrun = seciliButton.Tag as Urun;
            SeciliMasa.MasaDurumu = MasaDurumlar.Dolu;
            bool varMi = false;
            Siparis seciliSiparis = new Siparis();
            foreach (Siparis item in MasaninSiparisleri)
            {
                if (item.Urun.Id == _seciliUrun.Id)
                {
                    seciliSiparis = item;
                    varMi = true;
                    break;
                }
            }

            if (varMi)
            {
                seciliSiparis.Adet++;
                _siparisRepository.Update();
            }
            else
            {
                Siparis yeniSiparis = new Siparis()
                {
                    Adet = 1,
                    Urun = _seciliUrun,
                    Fiyat = _seciliUrun.Fiyat,
                    Masa = SeciliMasa
                };
                _siparisRepository.Add(yeniSiparis);
            }

            MasaninSiparisleri = _siparisRepository.GetAll(x =>
x.Masa.Id == SeciliMasa.Id && x.Masa.MasaDurumu == MasaDurumlar.Dolu);
            ListeyiDoldur();

        }

        private void ListeyiDoldur()
        {
            lstSiparis.Columns.Clear();
            lstSiparis.Items.Clear();
            lstSiparis.View = View.Details;
            lstSiparis.Columns.Add("Adet");
            lstSiparis.Columns.Add("Ürün");
            lstSiparis.Columns.Add("Ara Toplam");
            foreach (Siparis item in MasaninSiparisleri)
            {
                ListViewItem viewItem = new ListViewItem(item.Adet.ToString());
                viewItem.SubItems.Add(item.Urun.Ad);
                viewItem.SubItems.Add($"{item.AraToplam:c2}");
                lstSiparis.Items.Add(viewItem);
            }

            lstSiparis.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            decimal toplam = 0;
            foreach (Siparis item in MasaninSiparisleri)
            {
                toplam += item.AraToplam;
            }
            lblToplam.Text = $"{toplam:c2}";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
