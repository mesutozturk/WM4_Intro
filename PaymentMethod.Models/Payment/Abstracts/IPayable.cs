using PaymentMethod.Models.Payment.Models;

namespace PaymentMethod.Models.Payment.Abstracts
{
    public interface IPayable
    {
        void Pay(PaymentBase payment);
        MessageStates State { get; set; }
    }
}
