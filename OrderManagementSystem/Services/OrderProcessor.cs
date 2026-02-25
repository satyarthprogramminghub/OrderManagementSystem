using OrderManagementSystem.Models;
using OrderManagementSystem.Services.Discounts;
using OrderManagementSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services
{
    public class OrderProcessor
    {
        private readonly IOrderValidator _validator;
        private readonly DiscountFactory _discountFactory;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IOrderRepository _repository;
        private readonly INotificationService _notificationService;
        private readonly ILogger _logger;

        public OrderProcessor(
            IOrderValidator validator,
            DiscountFactory discountFactory,
            IPaymentProcessor paymentProcessor,
            IOrderRepository repository,
            INotificationService notificationService,
            ILogger logger)
        {
            _validator = validator;
            _discountFactory = discountFactory;
            _paymentProcessor = paymentProcessor;
            _repository = repository;
            _notificationService = notificationService;
            _logger = logger;
        }

        public void Process(Order order)
        {
            _validator.Validate(order);

            var discountCalculator = _discountFactory.GetStrategy(order.CustomerType!);
            var discount = discountCalculator.ApplyDiscount(order);
            order.TotalAmount -= discount;

            _paymentProcessor.ProcessPayment(order.PaymentMethod!);

            _repository.Save(order);

            _notificationService.SendEmail(order);

            _logger.Log("Order processed successfully.");

            _logger.Log("Order processed successfully.");
        }
    }

}
