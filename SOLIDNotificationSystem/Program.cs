using Domain;
using NotificationSystem.Application.Models;
using NotificationSystem.Application.Models.Notification;
using NotificationSystem.Application.Services.Notification.Impl;
using NotificationSystem.Application.Services.User.Impl;
using NotificationSystem.Application.Services.User.Interfaces;

namespace SOLIDNotificationSystem;

internal static class Program
{
    public static void Main(string[] args)
    {
        var adminUser = new User("John", "Cena", "his_name_is_JC@gmail.com", "098012007");
        var targetUser = new User("Tom", "Cruise", "tom_cruise@gmail.com", "098333666");

        //Sending email notification
        SendEmailNotification(adminUser, targetUser);

        //Sending SMS notification
        SendSmsNotification(adminUser, targetUser);

        //Sending push notification
        SendPushNotification(adminUser, targetUser);
    }

    private static void SendEmailNotification(User from, User to)
    {
        BaseNotification emailNotification = new EmailNotification(from: from.Email, to: to.Email,
            subject: "Next movie", message: "We need to discuss next movie production...");

        IUserService userService = new UserService(new EmailNotificationService());
        userService.Notify(emailNotification);
    }

    private static void SendSmsNotification(User from, User to)
    {
        BaseNotification smsNotification = new SmsNotification(from: from.Phone, to: to.Phone,
            message: "You should come to the office now!!!");

        IUserService userService = new UserService(new SmsNotificationService());
        userService.Notify(smsNotification);
    }

    private static void SendPushNotification(User from, User to)
    {
        BaseNotification pushNotification =
            new PushNotification(from: from.FullName, to: to.FullName, message: "Go play DOTA 2!!!");

        IUserService userService = new UserService(new PushNotificationService());
        userService.Notify(pushNotification);
    }
}