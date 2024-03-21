using NotificationSystem.Application.Models;
using NotificationSystem.Application.Services.Notification.Interfaces;

namespace NotificationSystem.Application.Services.Notification.Impl;

public class PushNotificationService : INotificationService
{
    public void SendNotification(Domain.User user, BaseNotification notification)
    {
        throw new NotImplementedException();
    }
}