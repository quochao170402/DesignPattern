using PaymentProcessingSystem.Models;

namespace PaymentProcessingSystem.Components;

public class CreditCardProcessor : IPaymentProcessor
{
    public PaymentResult ProcessPayment(PaymentOrder order)
    {
        Console.WriteLine(
            $"Processing Credit Card payment of {order.Amount} {order.Currency} for Order {order.OrderId}");

        return new PaymentResult
        {
            Success = true,
            TransactionId = Guid.NewGuid().ToString(),
            Status = PaymentStatus.Success,
            Message = "Credit card payment processed successfully."
        };
    }

    public PaymentResult RefundPayment(PaymentOrder order)
    {
        Console.WriteLine($"Refunding Credit Card payment for Order {order.OrderId}");

        return new PaymentResult
        {
            Success = true,
            TransactionId = Guid.NewGuid().ToString(),
            Status = PaymentStatus.Success,
            Message = "Credit card payment refunded successfully."
        };
    }
}

public class CreditCardValidator : IPaymentValidator
{
    public bool Validate(PaymentOrder order)
    {
        return order.Metadata.TryGetValue("CardNumber", out var cardNumber)
               && !string.IsNullOrWhiteSpace(cardNumber)
               && order.Metadata.TryGetValue("CardHolderName", out var holderName)
               && !string.IsNullOrWhiteSpace(holderName)
               && order.Metadata.TryGetValue("ExpirationDate", out var expDateStr)
               && DateTime.TryParse(expDateStr, out var expDate)
               && expDate > DateTime.UtcNow
               && order.Metadata.TryGetValue("CVV", out var cvv)
               && !string.IsNullOrWhiteSpace(cvv);
    }
}