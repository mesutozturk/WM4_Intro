using PaymentMethod.Models.Payment.Models;
using System;
using System.Windows.Forms;
using PaymentMethod.Models.Payment.Abstracts;
using PaymentMethod.Models.Payment.Managers;

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

        private Card yeniCard;
        private PaymentMethods method;
        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (yeniCard == null)
            //    yeniCard = new Card();

            //yeniCard = yeniCard ?? new Card();
            yeniCard = yeniCard ?? new Card();
            yeniCard ??= new Card();

            int a = 5;
            a = a + 5;
            a += 5;

            method = Enum.Parse<PaymentMethods>(cmbPaymentMethod.SelectedItem.ToString());
            PaymentMethods method2 = (PaymentMethods)Enum.Parse(typeof(PaymentMethods), cmbPaymentMethod.SelectedItem.ToString()); //2. yöntem
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

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            IPayable paymentManager;

            switch (method)
            {
                case PaymentMethods.Credit:
                    paymentManager = new CreditPaymentManager();

                    CreditPayment payment = new CreditPayment();
                    payment.Commission = 1.12m;
                    payment.Installment = taksitler[lstTaksitler.SelectedIndex];
                    payment.CustomerId = "123";
                    payment.Total = sepetTutari;
                    payment.CardInfo = new Card() // object initializer yöntemi ile propertylerin doldurulması
                    {
                        Year = 2021,
                        Cvv = txtCvv.Text,
                        Mount = 11,
                        NameSurname = txtAdSoyad.Text,
                        Number = txtCardNumber.Text
                    };

                    paymentManager.Pay(payment);
                    
                    break;
                case PaymentMethods.Debit:
                    paymentManager = new DebitPaymentManager();

                    DebitPayment payment2 = new DebitPayment();
                    payment2.Commission = 1.12m;
                    payment2.CustomerId = "123";
                    payment2.Total = sepetTutari;
                    payment2.CardInfo = new Card() // object initializer yöntemi ile propertylerin doldurulması
                    {
                        Year = 2021,
                        Cvv = txtCvv.Text,
                        Mount = 11,
                        NameSurname = txtAdSoyad.Text,
                        Number = txtCardNumber.Text
                    };
                    paymentManager.Pay(payment2);
                    break;
                default:
                    return;
            }

            if (paymentManager.State == MessageStates.Success)
            {
                MessageBox.Show("Ödeme işleminiz başarılı");
            }

            //Nullable<int> a = null;
            int? a = null;
        }
    }
}