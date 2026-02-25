using OrderManagementSystem.Models;
using OrderManagementSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagementSystem.Services
{
    public class NotificationService : INotificationService
    {
        public void SendEmail(Order order)
        {
            Console.WriteLine("Sending email to customer...");
        }
    }


}
