namespace ObserverPattern.EducationExample;

public class School : IAnnouncementSubject
{
    private readonly List<ISubscriber> _subscribers = [];

    public void Subscribe(ISubscriber subscriber)
    {
        if (_subscribers.Contains(subscriber))
        {
            return;
        }
        _subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void Notify(string message)
    {
        if (_subscribers.Count == 0)
        {
            return;
        }

        _subscribers.ForEach(x => x.ReceiveAnnouncement(message));
    }
}