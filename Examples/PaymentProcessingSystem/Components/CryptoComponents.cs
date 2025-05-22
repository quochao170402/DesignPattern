using PaymentProcessingSystem.Models;

namespace PaymentProcessingSystem.Components;

public class CryptoProcessor : IPaymentProcessor
{
    public PaymentResult ProcessPayment(PaymentOrder order)
    {
        Console.WriteLine(
            $"Processing Cryptocurrency payment of {order.Amount} {order.Currency} for Order {order.OrderId}");

        return new PaymentResult
        {
            Success = true,
            TransactionId = Guid.NewGuid().ToString(),
            Status = PaymentStatus.Success,
            Message = "Cryptocurrency payment processed successfully."
        };
    }

    public PaymentResult RefundPayment(PaymentOrder order)
    {
        Console.WriteLine($"Refunding Cryptocurrency payment for Order {order.OrderId}");

        return new PaymentResult
        {
            Success = true,
            TransactionId = Guid.NewGuid().ToString(),
            Status = PaymentStatus.Success,
            Message = "Cryptocurrency payment refunded successfully."
        };
    }
}

public class CryptoValidator : IPaymentValidator
{
    public bool Validate(PaymentOrder order)
    {
        return order.Metadata.TryGetValue("CryptoWalletAddress", out var walletAddress)
               && !string.IsNullOrWhiteSpace(walletAddress)
               && walletAddress.Length >= 26;
    }
}