using System;
using System.Collections.Generic;
using System.Text;
using OrderManagementSystem.Services.Discounts;

namespace OrderManagementSystem.Models
{
    public class SpecialDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(Order order)
        {
            if (order.TotalAmount < 500)
            {
                //throw new Exception("Special discount cannot be applied to small orders.");

                return 0; // No discount for orders below $500
            }

            return order.TotalAmount * 0.30;
        }
    }
}
