using OrderModule.Items;
using PaymentModule.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderModule.Interface
{
    public interface IOrderCore
    {
        double processOrder(OrderItem[] orderedItems);

        bool processPayment(IPaymentMethod paymentModule);

        string printReceipt();
    }
}
