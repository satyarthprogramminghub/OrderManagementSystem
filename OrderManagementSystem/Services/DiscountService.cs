using OrderManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services
{
    public class DiscountService
    {
        public double ApplyDiscount(Order order)
        {
            return order.CustomerType switch
            {
                "Regular" => order.TotalAmount * 0.05,
                "Premium" => order.TotalAmount * 0.10,
                "Gold" => order.TotalAmount * 0.20,
                _ => 0
            };
        }
    }
}
