using NUnit.Framework;
using OrderModule.Core;
using OrderModule.Items;
using PaymentModule;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void orderTotal1Item()
        {
            var orderCore = new OrderCore();
            Assert.AreEqual(120,orderCore.processOrder(new OrderItem[] { new OrderItem("Chicken Wings 6pcs.", 1, 120) }));
        }

        [Test]
        public void orderTotal2Items()
        {
            var orderCore = new OrderCore();
            Assert.AreEqual(190, orderCore.processOrder(new OrderItem[] { new OrderItem("Chicken Wings 6pcs.",1, 120), new OrderItem("Fries and Wings 3pcs.", 1, 70) }));
        }

        [Test]
        public void orderTotal2ItemWithQuantity()
        {
            var orderCore = new OrderCore();
            Assert.AreEqual(310, orderCore.processOrder(new OrderItem[] { new OrderItem("Chicken Wings 6pcs.", 2, 120), new OrderItem("Fries and Wings 3pcs.", 1, 70) }));
        }

        [Test]
        public void processPaymentWith1Item()
        {
            var orderCore = new OrderCore();

            orderCore.processOrder(new OrderItem[] { new OrderItem("Chicken Wings 6pcs.", 1, 120) });

            Assert.AreEqual(true, orderCore.processPayment(new CashPayment(120)));
        }

        [Test]
        public void processPaymentWith0Item()
        {
            var orderCore = new OrderCore();
            Assert.Throws<Exception>(() => orderCore.processPayment(new CashPayment(120)));
        }
    }
}