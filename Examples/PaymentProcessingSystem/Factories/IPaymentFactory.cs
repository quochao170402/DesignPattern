using PaymentProcessingSystem.Models;

namespace PaymentProcessingSystem.Factories;

public interface IPaymentFactory
{
    IPaymentComponentFactory CreateFamilyFactory(PaymentMethod method);
}

public class PaymentFactory : IPaymentFactory
{
    public IPaymentComponentFactory CreateFamilyFactory(PaymentMethod method)
    {
        return method switch
        {
            PaymentMethod.CreditCard => new CreditCardComponentFactory(),
            PaymentMethod.PayPal => new PayPalComponentFactory(),
            PaymentMethod.Crypto => new CryptoComponentFactory(),
            _ => throw new ArgumentOutOfRangeException(nameof(method), method, null)
        };
    }
}