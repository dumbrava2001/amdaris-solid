namespace NotificationSystem.Application.Models.Notification;

public class PushNotification : BaseNotification
{
    public PushNotification(string from, string to, string message) : base(from, to, message)
    {
    }
}