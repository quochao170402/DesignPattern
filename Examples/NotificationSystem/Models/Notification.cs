namespace NotificationSystem.Models;

public interface INotification
{
    public string Message { get; set; }

    void Display();
}

public class BaseNotification : INotification
{
    protected BaseNotification(string message)
    {
        Message = message;
    }

    public string Message { get; set; }

    public virtual void Display()
    {
        Console.WriteLine(Message);
    }
}

public class SmsNotification : BaseNotification
{
    public SmsNotification(string message) : base(message)
    {
        Message = message;
    }


    public override void Display()
    {
        Console.WriteLine("It is sms notification");
    }
}

public class EmailNotification : BaseNotification
{
    public EmailNotification(string message) : base(message)
    {
        Message = message;
    }


    public override void Display()
    {
        Console.WriteLine("It is email notification");
    }
}

public class PushNotification : BaseNotification
{
    public PushNotification(string message) : base(message)
    {
        Message = message;
    }


    public override void Display()
    {
        Console.WriteLine("It is push notification");
    }
}