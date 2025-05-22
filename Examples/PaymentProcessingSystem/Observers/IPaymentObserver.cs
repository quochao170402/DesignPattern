using PaymentProcessingSystem.Models;

namespace PaymentProcessingSystem.Observers;

public interface IPaymentObserver
{
    void Update(PaymentEvent paymentEvent);
}

public class UiPaymentObserver : IPaymentObserver
{
    public void Update(PaymentEvent paymentEvent)
    {
        Console.WriteLine($"UI notified: Payment {paymentEvent.OrderId} status changed to {paymentEvent.Status}");
    }
}

public class AccountingPaymentObserver : IPaymentObserver
{
    public void Update(PaymentEvent paymentEvent)
    {
        Console.WriteLine($"Accounting notified: Payment {paymentEvent.OrderId} status {paymentEvent.Status}");
    }
}

public class OrderManagementPaymentObserver : IPaymentObserver
{
    public void Update(PaymentEvent paymentEvent)
    {
        Console.WriteLine($"Order Management notified: Payment {paymentEvent.OrderId} status {paymentEvent.Status}");
    }
}