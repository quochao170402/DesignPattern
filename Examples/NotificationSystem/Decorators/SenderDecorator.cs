using NotificationSystem.Models;
using NotificationSystem.Strategies;

namespace NotificationSystem.Decorators;

public class LoggingNotificationDecorator(ISender wrappedSender) : ISender
{
    public void Send(List<ISubscriber> subscribers, INotification notification)
    {
        Console.WriteLine("Logging notification");
        wrappedSender.Send(subscribers, notification);
    }
}

public class EncryptionSenderDecorator(ISender wrappedSender) : ISender
{
    public void Send(List<ISubscriber> subscribers, INotification notification)
    {
        Console.WriteLine("Encrypted");

        wrappedSender.Send(subscribers, notification);
    }
}