using DefensiveCoding.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DefensiveCoding.Windows
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            var order = new Order();
            var payment = new Payment();

            var orderController = new OrderController();
            orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);
        }
    }
}
