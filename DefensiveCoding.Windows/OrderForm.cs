﻿using DefensiveCoding.BusinessLogic;
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
            Button button = sender as Button;

            if (button != null)
            {
                button.Text = "Processing ...";
            }

            PlaceOrder();
        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            var order = new Order();
            var payment = new Payment();

            var orderController = new OrderController();

            try
            {
                orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);
            }
            catch (ArgumentNullException ex)
            {
               // log the issue
               // display a message to the user that the order was not successful
            }
        }
    }
}
