using NotificationSystem.Models;
using NotificationSystem.Strategies;

namespace NotificationSystem.Observers;

public class Chanel
{
    private IFormater? _formater;
    private ISender? _sender;

    public Chanel(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    private List<ISubscriber> Subscribers { get; } = [];

    public void Subscribe(ISubscriber subscriber)
    {
        Subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        Subscribers.Remove(subscriber);
    }

    public void SendNotification(INotification notification)
    {
        if (_sender == null) throw new ArgumentException("Sender is null");

        if (_formater != null) notification.Message = _formater.Format(notification.Message);

        _sender.Send(Subscribers, notification);
    }

    public void SetSender(ISender sender)
    {
        _sender = sender;
    }

    public void SetFormater(IFormater formater)
    {
        _formater = formater;
    }
}