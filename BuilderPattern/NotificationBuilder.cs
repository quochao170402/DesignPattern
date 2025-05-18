namespace BuilderPattern;

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
        if (time == null) time = DateTime.Now;
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
        return new Notification
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