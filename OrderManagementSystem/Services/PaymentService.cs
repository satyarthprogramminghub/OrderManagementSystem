using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services
{
    public class PaymentService
    {
        public void ProcessPayment(string method)
        {
            if (method == "CreditCard")
                Console.WriteLine("Processing credit card payment...");
            else if (method == "PayPal")
                Console.WriteLine("Processing PayPal payment...");
            else
                throw new Exception("Unsupported payment method.");
        }
    }
}
