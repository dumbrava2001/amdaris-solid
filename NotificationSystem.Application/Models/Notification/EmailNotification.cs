namespace NotificationSystem.Application.Models.Notification;

public class EmailNotification : BaseNotification
{
    private string Subject { get; init; }

    public EmailNotification(string from, string to, string subject, string message) : base(from, to, message)
    {
        Subject = subject;
    }
}