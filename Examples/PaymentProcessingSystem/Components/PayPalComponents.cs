using PaymentProcessingSystem.Models;

namespace PaymentProcessingSystem.Components;

public class PayPalProcessor : IPaymentProcessor
{
    public PaymentResult ProcessPayment(PaymentOrder order)
    {
        Console.WriteLine($"Processing PayPal payment of {order.Amount} {order.Currency} for Order {order.OrderId}");

        return new PaymentResult
        {
            Success = true,
            TransactionId = Guid.NewGuid().ToString(),
            Status = PaymentStatus.Success,
            Message = "PayPal payment processed successfully."
        };
    }

    public PaymentResult RefundPayment(PaymentOrder order)
    {
        Console.WriteLine($"Refunding PayPal payment for Order {order.OrderId}");

        return new PaymentResult
        {
            Success = true,
            TransactionId = Guid.NewGuid().ToString(),
            Status = PaymentStatus.Success,
            Message = "PayPal payment refunded successfully."
        };
    }
}

public class PayPalValidator : IPaymentValidator
{
    public bool Validate(PaymentOrder order)
    {
        return order.Metadata.TryGetValue("PayPalEmail", out var email)
               && !string.IsNullOrWhiteSpace(email)
               && email.Contains('@');
    }
}