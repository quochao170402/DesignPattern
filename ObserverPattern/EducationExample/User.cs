namespace ObserverPattern.EducationExample;

public class User : ISubscriber, IBellNotification
{
    protected List<string> Messages { get; set; } = [];

    public void Display()
    {
        Messages.ForEach(x => Console.WriteLine($"{GetType().Name}: {x}"));
    }

    public void ReceiveAnnouncement(string message)
    {
        Messages.Add(message);
    }
}

public class Student : User
{
}

public class Parent : User
{
}

public class Administrator : User
{
}

public class Teacher : User
{
}