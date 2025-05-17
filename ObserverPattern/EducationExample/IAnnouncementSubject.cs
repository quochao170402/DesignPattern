namespace ObserverPattern.EducationExample;

public interface IAnnouncementSubject
{
    void Subscribe(ISubscriber subscriber);
    void Unsubscribe(ISubscriber subscriber);
    void Notify(string notification);
}