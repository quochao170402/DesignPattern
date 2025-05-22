namespace PaymentProcessingSystem.Models;

public class PaymentOrder
{
    public Guid OrderId { get; set; } = Guid.NewGuid();
    public PaymentMethod Method { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public Dictionary<string, string> Metadata { get; set; } = new();
}

public class PaymentResult
{
    public bool Success { get; set; }
    public string TransactionId { get; set; }
    public string Message { get; set; }
    public PaymentStatus Status { get; set; }

    public static PaymentResult None => new() { Success = false };
}

public class PaymentEvent
{
    public Guid OrderId { get; set; }
    public PaymentStatus Status { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public string Details { get; set; }
}
