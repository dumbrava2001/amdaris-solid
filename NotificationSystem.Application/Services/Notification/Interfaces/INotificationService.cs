using NotificationSystem.Application.Modules;

namespace NotificationSystem.Application.Services.Notification.Interfaces;

public interface INotificationService
{
    void SendNotification(Domain.User user, INotification notification);
}