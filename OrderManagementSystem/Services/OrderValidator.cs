using OrderManagementSystem.Models;
using OrderManagementSystem.Services.Interfaces;

namespace OrderManagementSystem.Services
{
    public class OrderValidator : IOrderValidator
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
