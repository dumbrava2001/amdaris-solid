﻿using NotificationSystem.Application.Models;

namespace NotificationSystem.Application.Services.Notification.Interfaces;

public interface INotificationService
{
    void SendNotification(BaseNotification notification);
}