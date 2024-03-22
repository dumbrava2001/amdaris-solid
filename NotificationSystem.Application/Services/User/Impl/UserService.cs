using NotificationSystem.Application.Models;
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

    public void Notify(BaseNotification notification)
    {
        Console.WriteLine("\nSending notification using notification service from user service");
        _notificationService.SendNotification(notification);
    }
}