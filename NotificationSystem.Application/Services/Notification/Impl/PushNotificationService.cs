﻿using NotificationSystem.Application.Modules;
using NotificationSystem.Application.Services.Notification.Interfaces;

namespace NotificationSystem.Application.Services.Notification.Impl;

public class PushNotificationService : INotificationService
{
    public void SendNotification(Domain.User user, INotification notification)
    {
        throw new NotImplementedException();
    }
}