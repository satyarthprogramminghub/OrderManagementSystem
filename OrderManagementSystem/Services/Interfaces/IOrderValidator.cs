using OrderManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services.Interfaces
{
    public interface IOrderValidator
    {
        void Validate(Order order);

    }
}
