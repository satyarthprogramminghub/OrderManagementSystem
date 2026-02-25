using OrderManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services
{
    public class OrderProcessor
    {
        private readonly OrderValidator _validator = new();
        private readonly DiscountService _discountService = new();
        private readonly PaymentService _paymentService = new();
        private readonly OrderRepository _repository = new();
        private readonly NotificationService _notificationService = new();
        private readonly Logger _logger = new();

        public void Process(Order order)
        {
            _validator.Validate(order);

            var discount = _discountService.ApplyDiscount(order);
            order.TotalAmount -= discount;

            _paymentService.ProcessPayment(order.PaymentMethod!);

            _repository.Save();

            _notificationService.SendEmail();

            _logger.Log("Order processed successfully.");
        }
    }

}
