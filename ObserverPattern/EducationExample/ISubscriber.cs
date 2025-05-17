namespace ObserverPattern.EducationExample;

public interface ISubscriber
{
    void ReceiveAnnouncement(string message);
}