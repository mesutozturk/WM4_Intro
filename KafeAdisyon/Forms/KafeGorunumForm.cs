using KafeAdisyon.Business;
using KafeAdisyon.Data;
using KafeAdisyon.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KafeAdisyon.Forms
{
    public partial class KafeGorunumForm : Form
    {
        public KafeGorunumForm()
        {
            InitializeComponent();
        }

        public CafeContext Context { get; set; }
        private KatRepository _katRepository;
        private SiparisRepository _siparisRepository;
        Color seciliKatColor = Color.Coral, defaultKatColor = Color.CornflowerBlue;
        private void KafeGorunumForm_Load(object sender, EventArgs e)
        {
            _katRepository = new KatRepository() { Context = Context };
            _siparisRepository = new SiparisRepository() { Context = Context };
            List<Kat> katlar = _katRepository
                .GetAll(x => x.Masalar.Count > 0)
                .OrderBy(x => x.Sira)
                .ToList();
            for (int i = 0; i < katlar.Count; i++)
            {
                Kat kat = katlar[i];
                Button btn = new Button()
                {
                    Text = kat.Ad,
                    Size = new Size(140, 95),
                    BackColor = defaultKatColor,
                    Tag = kat
                };
                btn.Click += KatBtn_Click;
                flpKatlar.Controls.Add(btn);
            }
        }

        private Kat _seciliKat;
        private void KatBtn_Click(object sender, EventArgs e)
        {
            Button seciliButton = sender as Button;

            _seciliKat = seciliButton.Tag as Kat;
            List<Masa> masalar = _seciliKat.Masalar;
            flpMasalar.Controls.Clear();
            foreach (Masa masa in masalar)
            {
                Button btn = new Button()
                {
                    Text = masa.Ad,
                    Size = new Size(140, 95),
                    BackColor = defaultKatColor,
                    Tag = masa
                };
                btn.Click += BtnMasa_Click;
                flpMasalar.Controls.Add(btn);
            }

            foreach (Button button in flpKatlar.Controls)
            {
                button.BackColor = defaultKatColor;
                if (button.Text == seciliButton.Text)
                    button.BackColor = seciliKatColor;
            }
        }

        private SiparisForm _frmSiparis;
        private void BtnMasa_Click(object sender, EventArgs e)
        {
            if (_frmSiparis == null || _frmSiparis.IsDisposed)
            {
                Button seciliButton = sender as Button;
                _frmSiparis = new SiparisForm();
                //_frmSiparis.MdiParent = this.MdiParent;
                _frmSiparis.WindowState = FormWindowState.Maximized;
                _frmSiparis.SeciliMasa = seciliButton.Tag as Masa;
                _frmSiparis.MasaninSiparisleri = _siparisRepository
                    .GetAll(x =>
                    x.Masa.Id == _frmSiparis.SeciliMasa.Id && x.Masa.MasaDurumu == MasaDurumlar.Dolu);
                _frmSiparis.Context = this.Context;
                _frmSiparis.ShowDialog();
            }
        }
    }
}
