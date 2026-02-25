using OrderManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services
{
    public class OrderValidator
    {
        public void Validate(Order order)
        {
            if (order.Items.Count == 0)
            {
                throw new Exception("Order must have at least one item.");
            }
        }
    }
}
