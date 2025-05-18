namespace BuilderPattern;

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