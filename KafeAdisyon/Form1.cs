using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KafeAdisyon.Data;
using KafeAdisyon.Forms;
using KafeAdisyon.Model;

namespace KafeAdisyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private CafeContext _context;
        private void Form1_Load(object sender, EventArgs e)
        {
            _context = new CafeContext();
            _context.Load();
        }

        private MenuForm frmMenu;
        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMenu == null || frmMenu.IsDisposed)
            {
                frmMenu = new MenuForm();
            }
            frmMenu.Context = _context;
            frmMenu.MdiParent = this;
            frmMenu.WindowState = FormWindowState.Maximized;
            frmMenu.Show();
        }

        private KatAyarForm frmKatAyar;
        private void katMasaAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKatAyar == null || frmKatAyar.IsDisposed)
            {
                frmKatAyar = new KatAyarForm();
            }
            frmKatAyar.Context = _context;
            frmKatAyar.MdiParent = this;
            frmKatAyar.WindowState = FormWindowState.Maximized;
            frmKatAyar.Show();
        }

        private KafeGorunumForm frmKafeGorunum;
        private void siparişEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKafeGorunum == null || frmKafeGorunum.IsDisposed)
            {
                frmKafeGorunum = new KafeGorunumForm();
            }

            frmKafeGorunum.Context = _context;
            frmKafeGorunum.MdiParent = this;
            frmKafeGorunum.WindowState = FormWindowState.Maximized;
            frmKafeGorunum.Show();
        }
    }
}
