using NotificationSystem.Models;

namespace NotificationSystem.Strategies;

public interface ISender
{
    void Send(List<ISubscriber> subscribers, INotification notification);
}

public class EmailSender : ISender
{
    public void Send(List<ISubscriber> subscribers, INotification notification)
    {
        Console.WriteLine("This is send message through email");
        subscribers.ForEach(x => x.ReceiveMessage(notification));
    }
}

public class SmsSender : ISender
{
    public void Send(List<ISubscriber> subscribers, INotification notification)
    {
        Console.WriteLine("This is send message through sms");
        subscribers.ForEach(x => x.ReceiveMessage(notification));
    }
}

public class PushNotificationSender : ISender
{
    public void Send(List<ISubscriber> subscribers, INotification notification)
    {
        Console.WriteLine("This is send message through push notification");
        subscribers.ForEach(x => x.ReceiveMessage(notification));
    }
}