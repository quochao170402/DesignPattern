using PaymentProcessingSystem.Models;

namespace PaymentProcessingSystem.Components;

public interface IPaymentProcessor
{
    PaymentResult ProcessPayment(PaymentOrder order);
    PaymentResult RefundPayment(PaymentOrder order);
}