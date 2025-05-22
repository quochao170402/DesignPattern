using PaymentProcessingSystem.Models;

namespace PaymentProcessingSystem.Components;

public interface IPaymentValidator
{
    bool Validate(PaymentOrder order);
}