using PaymentMethod.Models.Payment.Abstracts;
using PaymentMethod.Models.Payment.Models;
using System;

namespace PaymentMethod.Models.Payment.Managers
{
    public class DebitPaymentManager : IPayable
    {
        public MessageStates State { get; set; }
        public void Pay(PaymentBase payment)
        {
            try
            {
                //ödeme ayarları yapılır
                
                DebitPayment debit = payment as DebitPayment;
                //işlem başarılı
                State = MessageStates.Success;

                //db işlemleri
                //bildirim işlemleri
                //log işlemleri
            }
            catch (Exception ex)
            {
                //log işlemleri
                //bildirim
                State = MessageStates.Fail;
            }
        }
    }
}