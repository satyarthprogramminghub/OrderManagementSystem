using OrderManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services.Interfaces
{
    public interface INotificationService
    {
        void SendEmail(Order order);
    }
}
