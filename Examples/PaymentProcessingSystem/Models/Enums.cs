namespace PaymentProcessingSystem.Models;

public enum PaymentMethod
{
    CreditCard,
    PayPal,
    Crypto
}

public enum PaymentStatus
{
    Success,
    Failed,
    Pending
}
