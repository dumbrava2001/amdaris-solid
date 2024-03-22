using NotificationSystem.Application.Models;
using NotificationSystem.Application.Services.Notification.Interfaces;

namespace NotificationSystem.Application.Services.Notification.Impl;

public class EmailNotificationService : INotificationService
{
    public void SendNotification(BaseNotification notification)
    {
        Console.WriteLine("Creating smtp client connection...");
        Console.WriteLine($"Sending message to {notification.To} from {notification.From}");
    }
}