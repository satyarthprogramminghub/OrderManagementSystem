using OrderManagementSystem.Models;
using OrderManagementSystem.Services.Discounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services
{
    public class OrderProcessor
    {
        private readonly OrderValidator _validator = new();
        private readonly PaymentService _paymentService = new();
        private readonly OrderRepository _repository = new();
        private readonly NotificationService _notificationService = new();
        private readonly Logger _logger = new();

        public void Process(Order order)
        {
            _validator.Validate(order);

            var strategy = DiscountFactory.GetStrategy(order.CustomerType!);
            var discount = strategy.ApplyDiscount(order);

            _paymentService.ProcessPayment(order.PaymentMethod!);

            _repository.Save();

            _notificationService.SendEmail();

            _logger.Log("Order processed successfully.");
        }
    }

}
