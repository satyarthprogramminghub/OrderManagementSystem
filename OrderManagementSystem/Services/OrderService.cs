using OrderManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services
{
    public class OrderService
    {
        public void ProcessOrder(Order order)
        {
            // 1. Validate Order
            if (order.Items.Count == 0)
            {
                throw new Exception("Order must have at least one item.");
            }

            // 2. Calculate Discount
            double discount = 0;
            if (order.CustomerType == "Regular")
            {
                discount = order.TotalAmount * 0.05;
            }
            else if (order.CustomerType == "Premium")
            {
                discount = order.TotalAmount * 0.10;
            }
            else if (order.CustomerType == "Gold")
            {
                discount = order.TotalAmount * 0.20;
            }

            order.TotalAmount -= discount;

            // 3. Process Payment
            if (order.PaymentMethod == "CreditCard")
            {
                Console.WriteLine("Processing credit card payment...");
            }
            else if (order.PaymentMethod == "PayPal")
            {
                Console.WriteLine("Processing PayPal payment...");
            }
            else
            {
                throw new Exception("Unsupported payment method.");
            }

            // 4. Save to Database
            Console.WriteLine("Saving order to database...");

            // 5. Send Email Notification
            Console.WriteLine("Sending email to customer...");

            // 6. Log Activity
            Console.WriteLine("Order processed successfully.");
        }
    }
}
