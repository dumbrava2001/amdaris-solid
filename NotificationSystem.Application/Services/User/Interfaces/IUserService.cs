using NotificationSystem.Application.Models;

namespace NotificationSystem.Application.Services.User.Interfaces;

public interface IUserService
{
    void Notify(Domain.User user, BaseNotification notification);
}