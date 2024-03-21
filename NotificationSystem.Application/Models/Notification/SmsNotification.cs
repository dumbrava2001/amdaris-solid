namespace NotificationSystem.Application.Models.Notification;

public class SmsNotification : BaseNotification
{
    public SmsNotification(string from, string to, string message) : base(from, to, message)
    {
    }
}