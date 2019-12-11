using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DefensiveCoding.BusinessLogic
{
    public enum PaymentType
    {
        CreditCard = 1,
        PayPal = 2
    }
    public class Payment
    {
        public int PaymentType { get; set; }

        public void ProcessPayment(Payment payment)
        {
            PaymentType paymentTypeOption;

            bool isPaymentTypeValid = Enum.TryParse(value: PaymentType.ToString(), result: out paymentTypeOption);

            if (!isPaymentTypeValid)
            {
                throw new InvalidEnumArgumentException("Payment type", (int)this.PaymentType, typeof(PaymentType));
            }

            switch (paymentTypeOption)
            {
                case BusinessLogic.PaymentType.CreditCard:
                    break;
                case BusinessLogic.PaymentType.PayPal:
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
