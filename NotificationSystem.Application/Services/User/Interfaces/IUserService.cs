using NotificationSystem.Application.Modules;

namespace NotificationSystem.Application.Services.User.Interfaces;

public interface IUserService
{
    void Notify(Domain.User user, INotification notification);
}