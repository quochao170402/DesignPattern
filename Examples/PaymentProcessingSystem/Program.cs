// See https://aka.ms/new-console-template for more information

using PaymentProcessingSystem;
using PaymentProcessingSystem.Models;
using PaymentProcessingSystem.Observers;

Console.WriteLine("Hello, World!");

var order = new PaymentOrder
{
    Method = PaymentMethod.CreditCard,
    Amount = 100.00m,
    Currency = "USD",
    Metadata = new Dictionary<string, string>
    {
        { "CardNumber", "4111111111111111" },
        { "CardHolderName", "John Doe" },
        { "ExpirationDate", "2026-12-31" },
        { "CVV", "123" }
    }
};

// var order = new PaymentOrder
// {
//     Method = PaymentMethod.PayPal,
//     Amount = 50.00m,
//     Currency = "USD",
//     Metadata = new Dictionary<string, string>
//     {
//         { "PayPalEmail", "user@example.com" }
//     }
// };

// var order = new PaymentOrder
// {
//     Method = PaymentMethod.Crypto,
//     Amount = 0.005m,
//     Currency = "BTC",
//     Metadata = new Dictionary<string, string>
//     {
//         { "CryptoWalletAddress", "1BoatSLRHtKNngkdXEeobR76b53LETtpyT" }
//     }
// };


var gateway = PaymentGateway.Instance;
IPaymentObserver ui = new UiPaymentObserver();
IPaymentObserver accounting = new AccountingPaymentObserver();
IPaymentObserver orderManagement = new OrderManagementPaymentObserver();


gateway.RegisterObserver(ui);
gateway.RegisterObserver(accounting);
gateway.RegisterObserver(orderManagement);

gateway.ProcessPayment(order);

Console.WriteLine("======================================================================");
gateway.UnregisterObserver(accounting);
gateway.RefundPayment(order);
Console.WriteLine("======================================================================");

gateway.Undo();
