using Microsoft.VisualStudio.TestTools.UnitTesting;
using DefensiveCoding.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Common;

namespace DefensiveCoding.BusinessLogicTests
{
    [TestClass()]
    public class OrderControllerTests
    {
        [TestMethod()]
        public void PlaceOrderTest()
        {
            //-- Arrange 
            var orderController = new OrderController();
            var customer = new Customer() { EmailAddress = "info@erdiucar.com" };
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };

            //-- Act
            OperationResult operationResult = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);

            //-- Assert
            Assert.AreEqual(true, operationResult.Success);
            Assert.AreEqual(0, operationResult.MessageList.Count);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlaceOrderTestNullCustomer()
        {
            //-- Arrange 
            var orderController = new OrderController();
            Customer customer = null;
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };

            //-- Act
            OperationResult operationResult = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);

            //-- Assert
        }

        [TestMethod()]
        public void PlaceOrderTestInvalidEmail()
        {
            //-- Arrange 
            var orderController = new OrderController();
            var customer = new Customer() { EmailAddress = "" };
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };

            //-- Act
            OperationResult operationResult = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);

            //-- Assert
            Assert.AreEqual(true, operationResult.Success);
            Assert.AreEqual(1, operationResult.MessageList.Count);
            Assert.AreEqual("Email address is null", operationResult.MessageList[0]);
        }
    }
}