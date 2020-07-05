using OrderModule.Interface;
using OrderModule.Items;
using PaymentModule.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderModule.Core 
{
    public class OrderCore : IOrderCore
    {
        private OrderItem[] processedItems { get; set; }
        public string printReceipt()
        {
            throw new NotImplementedException();
        }

        public double processOrder(OrderItem[] orderedItems)
        {
            this.processedItems = orderedItems;
            return getProcessedItemTotal();
        }

        public bool processPayment(IPaymentMethod paymentModule)
        {
            if (hasItems() == false)
                throw new Exception("No processed items");

            if (isPaymentEnough(paymentModule.getPaymentEntered()))
                return paymentModule.process();

            return false;
        }
        private bool isPaymentEnough(double paymentValue)
        {
            if(getProcessedItemTotal() > paymentValue)
                return false;

            return true;
        }
        private double getProcessedItemTotal()
        {
            return processedItems.Select(order => order.ItemPrice * order.OrderQuantity).Sum();
        }

        private bool hasItems()
        {
            return (processedItems != null);
        }
    }
}
