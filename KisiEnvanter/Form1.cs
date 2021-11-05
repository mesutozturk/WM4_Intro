using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

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
            if (pbResim.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbResim.Image.Save(resimStream, ImageFormat.Jpeg);

                yeniKisi.Fotograf = resimStream.ToArray();
            }
            kisiler.Add(yeniKisi);
            ListeyiDoldur();
        }

        private Kisi seciliKisi;
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            seciliKisi = lstKisiler.SelectedItem as Kisi;

            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtTelefon.Text = seciliKisi.Telefon;
            dtpDogumTarihi.Value = seciliKisi.DogumTarihi;

            if (seciliKisi.Fotograf != null)
            {
                MemoryStream stream = new MemoryStream(seciliKisi.Fotograf);
                pbResim.Image = Image.FromStream(stream);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            seciliKisi.Ad = txtAd.Text;
            seciliKisi.Soyad = txtSoyad.Text;
            seciliKisi.Telefon = txtTelefon.Text;

            if (pbResim.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbResim.Image.Save(resimStream, ImageFormat.Jpeg);

                seciliKisi.Fotograf = resimStream.ToArray();
            }
            ListeyiDoldur();
        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Dışarı aktar";
            dialog.Filter = "XML Format | *.xml";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                TextWriter writer = new StreamWriter(dialog.FileName);
                serializer.Serialize(writer, kisiler);
                writer.Close();
                MessageBox.Show($"{kisiler.Count} adet kişi dışarı aktarıldı.");
            }
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir XML dosyası seçiniz";
            dialog.Filter = "XML | *.xml";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                XmlTextReader reader = new XmlTextReader(dialog.FileName);
                kisiler = (List<Kisi>)serializer.Deserialize(reader);
                MessageBox.Show($"{kisiler.Count} adet kişi içeri aktarıldı");
                ListeyiDoldur();
            }
        }

        private void jSONDışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Dışarı aktar";
            dialog.Filter = "JSON Format | *.json";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(dialog.FileName, FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(kisiler, Formatting.Indented));
                writer.Close();
                writer.Dispose();
                MessageBox.Show($"{kisiler.Count} adet kişi dışarı aktarıldı.");
            }
        }

        private void jSONİçeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir JSON dosyası seçiniz";
            dialog.Filter = "JSON | *.json";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(dialog.FileName, FileMode.Open);
                StreamReader reader = new StreamReader(fileStream);
                string dosyaIcerigi = reader.ReadToEnd();
                kisiler = JsonConvert.DeserializeObject<List<Kisi>>(dosyaIcerigi);
                MessageBox.Show($"{kisiler.Count} adet kişi içeri aktarıldı");
                ListeyiDoldur();
            }
        }
    }
}