using Cs.Lib.Abstracts;
using Cs.Lib.Concrete;
using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Cs.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSilahlar.DataSource = Enum.GetNames(typeof(Silahlar));
            tmrSeri.Tick += TmrSeri_Tick;
            SilahBilgisiGoster(silah);
        }

        private void TmrSeri_Tick(object sender, EventArgs e)
        {
            btnAtesEt.PerformClick();
            Thread.Sleep(500);
        }

        private Silah silah;
        private Timer tmrSeri = new Timer();
        private void cmbSilahlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSilahlar.SelectedItem == null) return;

            Silahlar seciliSilah = Enum.Parse<Silahlar>(cmbSilahlar.SelectedItem.ToString());
         

            switch (seciliSilah)
            {
                case Silahlar.Bıçak:
                    {
                        silah = new Bicak();
                        SoundPlayer player = new SoundPlayer((silah as IVurulabilir).BicakCıkarma);
                        player.Play();
                        break;
                    }
                    
                case Silahlar.USP:
                    silah = new Usp();
                    break;
                case Silahlar.Glock:
                    silah = new Glock();
                    break;
                case Silahlar.DesertEagle:
                    silah = new DesertEagle();
                    break;
                case Silahlar.AK47:
                    silah = new Ak47();
                    break;
                case Silahlar.M4A1S:
                    silah = new M4a1s();
                    break;
                case Silahlar.AWP:
                    silah = new Awp();
                    break;
                case Silahlar.ElBombası:
                    silah = new ElBombasi();
                    break;
                case Silahlar.FlashBombası:
                    silah = new FlashBombasi();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            if (silah == null) return;

            if (silah is IAtesEdebilen)
            {
                gb_AtesliSilah.Visible = true;
                gbFirlatilan.Visible = false;
                gbYakinSaldiri.Visible = false;
            }
            else if (silah is IFirlatilabilen)
            {
                gb_AtesliSilah.Visible = false;
                gbFirlatilan.Visible = true;
                gbYakinSaldiri.Visible = false;
            }
            else
            {
                gb_AtesliSilah.Visible = false;
                gbFirlatilan.Visible = false;
                gbYakinSaldiri.Visible = true;
            }
            panelSilah.Controls.Clear();
            PictureBox pbBox = new PictureBox();
            pbBox.Image = Image.FromStream(silah.SilahResim);
            pbBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SilahBilgisiGoster(silah);
            pbBox.Dock = DockStyle.Fill;
            panelSilah.Controls.Add(pbBox);
        }


        private void SilahBilgisiGoster(Silah silah)
        {
            lblDetay.Text = $"Ülke: {silah.Ulke}\nFiyat: {silah.Fiyat:c2}";
            if (silah is ISarjorlu sarjorluSilahlar)
                lblDurum.Text = $"{sarjorluSilahlar.KalanFisek}/{sarjorluSilahlar.SarjorKapasitesi}";
        }
        private void btnAtesEt_Click(object sender, EventArgs e)
        {
            btnAtesEt.Enabled = false;
            IAtesEdebilen atesliSilah = silah as IAtesEdebilen;
            SilahBilgisiGoster(silah);
            int sayi = atesliSilah.AtesEt();
            SoundPlayer player;
            if (sayi != 0)
            {
                player = new SoundPlayer(atesliSilah.AtisSesi);
                atesliSilah.AtisSesi.Position = 0;
            }
            else
            {
                player = new SoundPlayer(atesliSilah.BitikFisekSesi);
                atesliSilah.BitikFisekSesi.Position = 0;
            }
            player.Play();
            btnAtesEt.Enabled = true;
        }

        private void btnYenidenDoldur_Click(object sender, EventArgs e)
        {
            ISarjorlu atesliSilah = silah as ISarjorlu;
            atesliSilah.YenidenDoldur();
            SilahBilgisiGoster(silah);
            SoundPlayer player = new SoundPlayer(atesliSilah.YenidenDoldurmaSesi);
            atesliSilah.YenidenDoldurmaSesi.Position = 0;
            player.Play();
        }

        private void btnAtesEt_MouseDown(object sender, MouseEventArgs e)
        {
            if (silah is ISeriAtabilir ss)
            {
                tmrSeri.Interval = ss.AtisKatsayisi;
                tmrSeri.Start();
            }
        }

        private void btnAtesEt_MouseUp(object sender, MouseEventArgs e)
        {
            if (silah is ISeriAtabilir)
            {
                tmrSeri.Stop();
            }
        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            btnSaldir.Enabled = false;
            IVurulabilir vurulabilir = silah as IVurulabilir;
            vurulabilir.Vur();
            //(silah as IVurulabilir).Vur();
            SoundPlayer player = new SoundPlayer(vurulabilir.BicakSaplama);
            player.Play();
            btnSaldir.Enabled = true;
        }

        private void btnFırlat_Click(object sender, EventArgs e)
        {
            btnFırlat.Enabled = false;
            IFirlatilabilen firlat = silah as IFirlatilabilen;
            firlat.Firlat();
            SoundPlayer player = new SoundPlayer(firlat.Bomba);
            player.Play();
            btnFırlat.Enabled = true;
        }
    }
}
