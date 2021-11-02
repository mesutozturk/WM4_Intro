using System;

namespace PaymentMethod.Models.Payment.Abstracts
{
    public abstract class PaymentBase
    {
        public string CustomerId { get; set; }
        public decimal Total { get; set; }
        public decimal TaxAmout { get; set; }
        public DateTime PaymentDate { get; } = DateTime.Now;
    }
}
