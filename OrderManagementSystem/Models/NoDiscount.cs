using OrderManagementSystem.Services.Discounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Models
{
    internal class NoDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(Order order) => 0;

    }
}
