using OrderManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services.Discounts
{
    public static class DiscountFactory
    {
        public static IDiscountStrategy GetStrategy(string customerType)
        {
            return customerType switch
            {
                "Regular" => new RegularDiscount(),
                "Premium" => new PremiumDiscount(),
                "Gold" => new GoldDiscount(),
                "Special" => new SpecialDiscount(),
                _ => new NoDiscount()
            };
        }
    }
}
