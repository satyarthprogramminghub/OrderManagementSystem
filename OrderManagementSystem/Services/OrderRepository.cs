using OrderManagementSystem.Models;
using OrderManagementSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services
{
    public class OrderRepository : IOrderRepository
    {
        public void Save(Order order)
        {
            Console.WriteLine("Saving order to database...");
        }
    }
}
