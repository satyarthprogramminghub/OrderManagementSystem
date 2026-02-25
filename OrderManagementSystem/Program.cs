using OrderManagementSystem.Models;
using OrderManagementSystem.Services;

namespace OrderManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                Items = new List<string> { "Laptop", "Mouse" },
                CustomerType = "Premium",
                PaymentMethod = "CreditCard",
                TotalAmount = 1000
            };

            var service = new OrderService();
            service.ProcessOrder(order);

            Console.WriteLine($"Final Amount: {order.TotalAmount}");

        }
    }
}
