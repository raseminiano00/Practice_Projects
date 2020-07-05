using PaymentModule.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentModule
{
    public class CashPayment : IPaymentMethod
    {
        private double paymentEntered=0;

        public CashPayment(double paymentAmount)
        {
            this.paymentEntered = paymentAmount;
        }

        public double getPaymentEntered()
        {
            return paymentEntered;
        }

        public bool process()
        {
            return true;
        }
    }
}
