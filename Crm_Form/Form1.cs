using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Crm_Form.Formlar;
using Crm_Form.Models;

namespace Crm_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Programı kapatmak istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                e.Cancel = true;
        }
        //singleton
        private FrmDisariAktar _frmDisariAktar;
        private void dışarıAktarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmDisariAktar == null || _frmDisariAktar.IsDisposed)
                _frmDisariAktar = new FrmDisariAktar();
            _frmDisariAktar.MdiParent = this;
            _frmDisariAktar.Show();
        }

        private FrmIceriAktar _frmIceriAktar;
        private void içeriAktarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmIceriAktar == null || _frmIceriAktar.IsDisposed)
                _frmIceriAktar = new FrmIceriAktar();
            _frmIceriAktar.MdiParent = this;
            _frmIceriAktar.Show();
        }

        public List<Kisi> Kisiler { get; set; }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            var context = new Context();
            Kisiler = context.Kisiler;
            Console.WriteLine();
        }

        private FrmKisiEkleForm _frmKisiEkle;
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmKisiEkle == null || _frmKisiEkle.IsDisposed)
            {
                _frmKisiEkle = new FrmKisiEkleForm();
                _frmKisiEkle.MdiParent = this;
                _frmKisiEkle.Show();
            }
        }

        private FrmKisiGuncelle _frmKisiGuncelle;
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmKisiGuncelle == null || _frmKisiGuncelle.IsDisposed)
            {
                _frmKisiGuncelle = new FrmKisiGuncelle();
                _frmKisiGuncelle.MdiParent = this;
                _frmKisiGuncelle.StartPosition = FormStartPosition.CenterParent;
                _frmKisiGuncelle.Kisi = Kisiler.Last();
                _frmKisiGuncelle.Show();
            }
        }
        FrmKisiListele _frmKisiListele;
        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/5233502/how-to-return-a-value-from-a-form-in-c
            _frmKisiListele = new FrmKisiListele();
            //_frmKisiListele.MdiParent = this;
            _frmKisiListele.StartPosition = FormStartPosition.CenterScreen;
            _frmKisiListele.Kisiler = Kisiler;
            var result = _frmKisiListele.ShowDialog();
            if (result == DialogResult.OK)
            {
                var seciliKisi = _frmKisiListele.SeciliKisi;
                MessageBox.Show($"Seçili kişi: {seciliKisi}");
            }
        }
    }
}
