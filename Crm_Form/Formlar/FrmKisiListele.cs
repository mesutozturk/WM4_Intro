using Crm_Form.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Crm_Form.Formlar
{
    public partial class FrmKisiListele : Form
    {
        public FrmKisiListele()
        {
            InitializeComponent();
        }
        public List<Kisi> Kisiler { get; set; }
        private void FrmKisiListele_Load(object sender, EventArgs e)
        {
            lstKisiler.DataSource = Kisiler;
        }
        public Kisi SeciliKisi { get; set; }
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            SeciliKisi = lstKisiler.SelectedItem as Kisi;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (SeciliKisi == null)
            {
                MessageBox.Show("Bir kişi seçmediniz");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SeciliKisi == null)
            {
                MessageBox.Show("Bir kişi seçmediniz");
                return;
            }
            var result = MessageBox.Show($"{SeciliKisi} kişisini silmek istiyor musunuz?", "Kişi sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Kisiler.Remove(SeciliKisi);
                lstKisiler.SelectedIndex = -1;
                lstKisiler.DataSource = null;
                lstKisiler.DataSource = Kisiler;
                //lstKisiler.;
                SeciliKisi = null;
            }
        }
    }
}
