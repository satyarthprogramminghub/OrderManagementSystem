using Microsoft.Extensions.DependencyInjection;
using OrderManagementSystem.Models;
using OrderManagementSystem.Services;
using OrderManagementSystem.Services.Discounts;
using OrderManagementSystem.Services.Interfaces;


namespace OrderManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            // Core services
            services.AddTransient<IOrderValidator, OrderValidator>();
            services.AddTransient<IPaymentProcessor, PaymentService>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<INotificationService, NotificationService>();
            services.AddTransient<ILogger, Logger>();

            // Discount strategies
            services.AddTransient<RegularDiscount>();
            services.AddTransient<PremiumDiscount>();
            services.AddTransient<GoldDiscount>();
            services.AddTransient<SpecialDiscount>();
            services.AddTransient<NoDiscount>();

            // Factory
            services.AddSingleton<DiscountFactory>();


            // High-level service
            services.AddTransient<OrderProcessor>();

            var provider = services.BuildServiceProvider();

            // Sample order
            var order = new Order
            {
                Items = new List<string> { "Laptop", "Mouse" },
                CustomerType = "Regular",
                PaymentMethod = "CreditCard",
                TotalAmount = 1000
            };

            var processor = provider.GetRequiredService<OrderProcessor>();
            processor.Process(order);

            Console.WriteLine($"Final Amount: {order.TotalAmount}");

        }
    }
}
