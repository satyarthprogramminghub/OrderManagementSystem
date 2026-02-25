using System;
using OrderManagementSystem.Services.Discounts;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Models
{
    public class GoldDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(Order order)
        {
            return order.TotalAmount * 0.20;
        }

    }
}
