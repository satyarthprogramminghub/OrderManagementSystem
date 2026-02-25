using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Models
{
    public class Order
    {
        public List<string> Items { get; set; } = new();
        public string? CustomerType { get; set; }
        public string? PaymentMethod { get; set; }
        public double TotalAmount { get; set; }
    }

}
