using System;
using System.Windows.Forms;

namespace Crm_Form.Formlar
{
    public partial class FrmLoginForm : Form
    {
        public FrmLoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                //MessageBox.Show("Hoşgeldin admin");

                Form1 anaForm = new Form1();
                anaForm.Show();
                this.Hide();
            }
        }
    }
}
