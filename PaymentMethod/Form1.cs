using PaymentMethod.Models.Payment.Models;
using System;
using System.Windows.Forms;

namespace PaymentMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] taksitler = new[] { 1, 2, 3, 6, 9, 12 };
        private decimal sepetTutari = new Random().Next(1000, 10000);
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPaymentMethod.DataSource = Enum.GetNames(typeof(PaymentMethods));
            for (int i = 1; i <= 12; i++)
            {
                cmbAy.Items.Add($"{i:00}");
            }

            //for (int i = DateTime.Now.Year; i <= DateTime.Now.Year + 10; i++)
            //{
            //    cmbYil.Items.Add(i);
            //}

            for (DateTime i = DateTime.Now; i <= DateTime.Now.AddYears(10); i = i.AddYears(1))
            {
                //cmbYil.Items.Add(i.Year.ToString().Substring(2));
                cmbYil.Items.Add($"{i:yy}");
            }
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaymentMethods method = Enum.Parse<PaymentMethods>(cmbPaymentMethod.SelectedItem.ToString());
            //PaymentMethods method = (PaymentMethods)Enum.Parse(cmbPaymentMethod.SelectedItem.ToString());
            lstTaksitler.Items.Clear();
            this.Text = $"{sepetTutari:c2}";
            if (method == PaymentMethods.Debit)
            {
                lstTaksitler.Items.Add($"Tek Çekim - {sepetTutari:c2}");
            }
            else if (method == PaymentMethods.Credit)
            {
                foreach (int taksit in taksitler)
                {
                    lstTaksitler.Items.Add($"{taksit} x {(sepetTutari / taksit):c2}");
                }
            }
        }
    }
}
