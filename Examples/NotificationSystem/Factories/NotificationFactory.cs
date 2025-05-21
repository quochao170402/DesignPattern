using NotificationSystem.Models;

namespace NotificationSystem.Factories;

public interface INotificationFactory
{
    INotification CreateNotification(NotificationType type, string message);
}

public class NotificationFactory : INotificationFactory
{
    public INotification CreateNotification(NotificationType type, string message)
    {
        return type switch
        {
            NotificationType.Sms => new SmsNotification(message),
            NotificationType.Email => new EmailNotification(message),
            NotificationType.PushNotification => new PushNotification(message),
            _ => new EmailNotification(message)
        };
    }
}