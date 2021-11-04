using PaymentMethod.Models.Payment.Models;
using System;
using System.Windows.Forms;

namespace PaymentMethod.UserControls
{
    public delegate void AdSoyadHataEvent(object sender, KeyPressEventArgs e);
    public partial class CreditCardBox : UserControl
    {
        public CreditCardBox()
        {
            InitializeComponent();
        }

        public string KartNo
        {
            get => txtKartNo.Text;
            set => txtKartNo.Text = value;
        }
        public string AdSoyad
        {
            get => txtAdSoyad.Text;
            set => txtAdSoyad.Text = value;
        }
        public string Ay
        {
            get => cmbAy.SelectedItem.ToString();
            set
            {
                string format = $"{int.Parse(value):00}";
                int index = cmbAy.Items.IndexOf(format);
                if (index != -1)
                    cmbAy.SelectedIndex = index;
            }
        }
        public string Yil
        {
            get => cmbYil.SelectedItem.ToString();
            set
            {
                string format = $"{int.Parse(value):00}";
                int index = cmbYil.Items.IndexOf(format);
                if (index != -1)
                    cmbYil.SelectedIndex = index;
            }
        }
        public string Cvv
        {
            get => txtCvv.Text;
            set => txtCvv.Text = value;
        }
        public Card CardInfo =>
            new Card()
            {
                Year = int.Parse(this.Yil),
                Cvv = this.Cvv,
                Mount = int.Parse(this.Ay),
                NameSurname = this.AdSoyad,
                Number = this.KartNo
            };

        public event AdSoyadHataEvent AdSoyadHata;

        private void CreditCardBox_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbAy.Items.Add($"{i:00}");
            }

            for (DateTime i = DateTime.Now; i <= DateTime.Now.AddYears(10); i = i.AddYears(1))
            {
                cmbYil.Items.Add($"{i:yy}");
            }
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                AdSoyadHata?.Invoke(sender, e);
            }

        }
    }
}