using NotificationSystem.Application.Models;
using NotificationSystem.Application.Services.Notification.Interfaces;

namespace NotificationSystem.Application.Services.Notification.Impl;

public class PushNotificationService : INotificationService
{
    public void SendNotification(BaseNotification notification)
    {
        Console.WriteLine("Create notification window...");
        Console.WriteLine($"Display notification window to {notification.To} from {notification.From}");
    }
}