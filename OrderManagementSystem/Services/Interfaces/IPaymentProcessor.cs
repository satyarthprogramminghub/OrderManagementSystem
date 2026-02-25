using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services.Interfaces
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(string method);
    }
}
