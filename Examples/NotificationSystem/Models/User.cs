namespace NotificationSystem.Models;

public interface ISubscriber
{
    void ReceiveMessage(INotification notification);
}

public class User(string name) : ISubscriber
{
    private string Name { get; } = name;

    public void ReceiveMessage(INotification notification)
    {
        Console.WriteLine($"{Name} receive message: {notification.GetType().Name} {notification.Message}");
    }
}