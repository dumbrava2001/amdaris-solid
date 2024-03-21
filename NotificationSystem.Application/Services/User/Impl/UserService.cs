using NotificationSystem.Application.Modules;
using NotificationSystem.Application.Services.Notification.Interfaces;
using NotificationSystem.Application.Services.User.Interfaces;

namespace NotificationSystem.Application.Services.User.Impl;

public class UserService : IUserService
{
    private readonly INotificationService _notificationService;

    public UserService(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void Notify(Domain.User user, INotification notification)
    {
        Console.WriteLine("Sending notification using notification service");
        _notificationService.SendNotification(user, notification);
    }
}