using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crm_Form.Models;

namespace Crm_Form.Formlar
{
    public partial class FrmKisiGuncelle : Form
    {
        public FrmKisiGuncelle()
        {
            InitializeComponent();
        }

        public Kisi Kisi { get; set; }
        private void FrmKisiGuncelle_Load(object sender, EventArgs e)
        {
            this.Text = $"{Kisi.Ad} {Kisi.Soyad}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kisi.Ad = Faker.NameFaker.FirstName();
            Kisi.Soyad = Faker.NameFaker.LastName();
            this.Close();
        }
    }
}
