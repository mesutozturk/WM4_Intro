using PaymentMethod.Models.Payment.Models;

namespace PaymentMethod.Models.Payment.Abstracts
{
    public interface IPayable
    {
        void Pay(decimal amount);
        MessageStates State { get; set; }
    }
}
