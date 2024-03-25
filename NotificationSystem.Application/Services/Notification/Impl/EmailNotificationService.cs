using NotificationSystem.Application.Models;
using NotificationSystem.Application.Models.Notification;
using NotificationSystem.Application.Services.Notification.Interfaces;

namespace NotificationSystem.Application.Services.Notification.Impl;

public class EmailNotificationService : INotificationService
{
    public void SendNotification(BaseNotification notification)
    {
        var emailNotification = (EmailNotification)notification;
        Console.WriteLine("Creating smtp client connection...");
        Console.WriteLine($"Sending message to {emailNotification.To} from {emailNotification.From} with subject: {emailNotification.Subject}");
    }
}