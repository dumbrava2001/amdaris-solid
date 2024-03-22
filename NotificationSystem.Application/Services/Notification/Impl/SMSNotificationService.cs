using NotificationSystem.Application.Models;
using NotificationSystem.Application.Services.Notification.Interfaces;

namespace NotificationSystem.Application.Services.Notification.Impl;

public class SmsNotificationService : INotificationService
{
    public void SendNotification(BaseNotification notification)
    {
        Console.WriteLine("Create phone network provider link...");
        Console.WriteLine($"Sending sms to {notification.To} from {notification.From}");
    }
}