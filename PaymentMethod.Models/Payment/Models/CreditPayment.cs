using PaymentMethod.Models.Payment.Abstracts;

namespace PaymentMethod.Models.Payment.Models
{
    public class CreditPayment : PaymentBase
    {
        public int Installment { get; set; }
        public decimal Commission { get; set; }
        public Card CardInfo { get; set; }
    }
}