using OrderManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services.Discounts
{
    public interface IDiscountStrategy
    {
        double ApplyDiscount(Order order);
    }
}
