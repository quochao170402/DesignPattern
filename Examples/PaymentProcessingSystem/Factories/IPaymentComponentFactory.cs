using PaymentProcessingSystem.Components;
using PaymentProcessingSystem.Models;

namespace PaymentProcessingSystem.Factories;

public interface IPaymentComponentFactory
{
    IPaymentProcessor CreateProcessor(PaymentMethod method);
    IPaymentValidator CreateValidator(PaymentMethod method);
}

public class CreditCardComponentFactory : IPaymentComponentFactory
{
    public IPaymentProcessor CreateProcessor(PaymentMethod method)
    {
        return new CreditCardProcessor();
    }

    public IPaymentValidator CreateValidator(PaymentMethod method)
    {
        return new CreditCardValidator();
    }
}

public class PayPalComponentFactory : IPaymentComponentFactory
{
    public IPaymentProcessor CreateProcessor(PaymentMethod method)
    {
        return new PayPalProcessor();
    }

    public IPaymentValidator CreateValidator(PaymentMethod method)
    {
        return new PayPalValidator();
    }
}

public class CryptoComponentFactory : IPaymentComponentFactory
{
    public IPaymentProcessor CreateProcessor(PaymentMethod method)
    {
        return new CryptoProcessor();
    }

    public IPaymentValidator CreateValidator(PaymentMethod method)
    {
        return new CryptoValidator();
    }
}