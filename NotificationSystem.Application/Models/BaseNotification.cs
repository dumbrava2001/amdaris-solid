namespace NotificationSystem.Application.Models;

public abstract class BaseNotification
{
    public string From { get; init; }
    private string To { get; init; }
    private string Message { get; init; }

    protected BaseNotification(string from, string to, string message)
    {
        From = from;
        To = to;
        Message = message;
    }
}