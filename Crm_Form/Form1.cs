using System.Windows.Forms;
using Crm_Form.Formlar;

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
    }
}
