# Builder pattern
The Builder Pattern is a creational design pattern that allows for the step-by-step creation of complex objects using a builder interface. This pattern is particularly useful when an object needs to be created in multiple steps or when an object can have a variety of configurations.

## Advantages
- **Simplifies object creation:** By breaking down the construction process into smaller steps, the Builder Pattern makes it easier to create complex objects.
- **Improves code readability:** The pattern separates the construction logic from the representation, making the code more readable and maintainable.
- **Provides control over the construction process:** The builder interface allows for fine-grained control over the construction process, enabling the creation of objects with different configurations.

## Example
Here is a simple example of the Builder Pattern in Java:

```C#
public class Notification
{
    public Guid Id { get; set; }
    public int SenderId { get; set; }
    public int ReceiverId { get; set; }
    public DateTime SendAt { get; set; }
    public string EmailAddress { get; set; } // Required
    public string? Content { get; set; } // Optional
    public string? Notice { get; set; } // Optional
    public string? FacebookAccount { get; set; } // Optional

    public override string ToString()
    {
        return $"{Id} {ReceiverId} {SenderId} {SendAt} {EmailAddress} {FacebookAccount} {Notice} {Content}";
    }
}

public class NotificationBuilder
{
    public Guid Id { get; set; }
    public int SenderId { get; set; }
    public int ReceiverId { get; set; }
    public DateTime SendAt { get; set; }
    public string EmailAddress { get; set; } // Required
    public string? Content { get; set; } // Optional
    public string? Notice { get; set; } // Optional
    public string? FacebookAccount { get; set; } // Optional

    public NotificationBuilder AddContent(string content)
    {
        Content = content;
        return this;
    }

    public NotificationBuilder AddSender(int senderId)
    {
        SenderId = senderId;
        return this;
    }


    public NotificationBuilder AddReceiver(int receiverId)
    {
        ReceiverId = receiverId;
        return this;
    }


    public NotificationBuilder AddTime(DateTime? time)
    {
        if (time == null)
        {
            time = DateTime.Now;
        }
        SendAt = (DateTime)time;
        return this;
    }

    public NotificationBuilder AddEmailAddress(string address)
    {
        EmailAddress = address;
        return this;
    }

    public NotificationBuilder AddFacebookAccount(string account)
    {
        FacebookAccount = account;
        return this;
    }
    public NotificationBuilder AddNotice(string notice)
    {
        Notice = notice;
        return this;
    }

    public Notification Build()
    {
        return new Notification()
        {
            Id = Guid.NewGuid(),
            SenderId = SenderId,
            ReceiverId = ReceiverId,
            EmailAddress = EmailAddress,
            Content = Content,
            Notice = Notice,
            FacebookAccount = FacebookAccount

        };
    }
}

// Program.cs
NotificationBuilder builder = new NotificationBuilder();
Notification notification = builder.AddNotice("Notice")
                                    .AddContent("Content")
                                    .AddEmailAddress("abc@gmail.com")
                                    .AddReceiver(1)
                                    .AddSender(2)
                                    .Build();

System.Console.WriteLine(notification);

```

In this example, the `NotificationBuilder` class provides methods to set the different parts of the notification. The `Build` method then constructs the `Notification` object using the specified configurations.

## Use Cases
- When an object requires multiple steps to be created.
- When an object can have different representations or configurations.
- When the construction process needs to be independent of the components that make up the object.

By using the Builder Pattern, you can create complex objects in a more manageable and readable way.