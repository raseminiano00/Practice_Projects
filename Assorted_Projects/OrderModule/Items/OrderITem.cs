using System;
using System.Collections.Generic;
using System.Text;

namespace OrderModule.Items
{
    public class OrderItem
    {
        public OrderItem(string ItemName,int OrderQuantity,double ItemPrice)
        {
            this.ItemName = ItemName;
            this.OrderQuantity = OrderQuantity;
            this.ItemPrice = ItemPrice;
        }
        public string ItemName { get; set; }
        public int OrderQuantity { get; set; }
        public double ItemPrice { get; set; }
    }
}
