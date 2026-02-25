using OrderManagementSystem.Services.Discounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Models
{
    public class PremiumDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(Order order)
        {
            return order.TotalAmount * 0.10;
        }

    }
}
