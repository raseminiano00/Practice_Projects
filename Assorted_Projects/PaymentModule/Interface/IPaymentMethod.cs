using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentModule.Interface
{
    public interface IPaymentMethod
    {
        bool process();

        double getPaymentEntered();
    }
}
