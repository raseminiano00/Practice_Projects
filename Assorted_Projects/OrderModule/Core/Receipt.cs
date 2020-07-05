using OrderModule.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderModule.Core
{
    public class Receipt
    {
        public OrderItem[] PurchasedItems { get; set; }
    }
}
