using OrderManagementSystem.Models;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services.Discounts
{
    public class DiscountFactory
    {
        private readonly IServiceProvider _provider;

        public DiscountFactory(IServiceProvider provider)
        {
            _provider = provider;
        }


        public IDiscountStrategy GetStrategy(string customerType)
        {
            return customerType switch
            {
                "Regular" => _provider.GetRequiredService<RegularDiscount>(),
                "Premium" => _provider.GetRequiredService<PremiumDiscount>(),
                "Gold" => _provider.GetRequiredService<GoldDiscount>(),
                "Special" => _provider.GetRequiredService<SpecialDiscount>(),
                _ => _provider.GetRequiredService<NoDiscount>()

            };
        }
    }
}
