using PaymentMethod.Models.Payment.Abstracts;

namespace PaymentMethod.Models.Payment.Models
{
    public class DebitPayment : PaymentBase
    {
        public decimal Commission { get; set; }
        public Card CardInfo { get; set; }
    }
}