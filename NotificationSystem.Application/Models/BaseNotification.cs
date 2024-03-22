namespace NotificationSystem.Application.Models;

public abstract class BaseNotification
{
    public string From { get; init; }
    public string To { get; init; }
    public string Message { get; init; }

    protected BaseNotification(string from, string to, string message)
    {
        From = from;
        To = to;
        Message = message;
    }
}