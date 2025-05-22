using PaymentProcessingSystem.Commands;
using PaymentProcessingSystem.Components;
using PaymentProcessingSystem.Factories;
using PaymentProcessingSystem.Models;
using PaymentProcessingSystem.Observers;

namespace PaymentProcessingSystem;

public sealed class PaymentGateway
{
    private static readonly Lazy<PaymentGateway> _instance = new(() => new PaymentGateway());
    private readonly Stack<IPaymentCommand> _commandHistories = new();

    private readonly List<IPaymentObserver> _observers = [];
    private IPaymentCommand _command;

    private PaymentGateway()
    {
    }

    private IPaymentFactory _factory { get; } = new PaymentFactory();

    public static PaymentGateway Instance => _instance.Value;

    private IPaymentProcessor GetProcessor(PaymentMethod paymentMethod)
    {
        var componentFactory = _factory.CreateFamilyFactory(paymentMethod);
        return componentFactory.CreateProcessor(paymentMethod);
    }

    private IPaymentValidator GetValidator(PaymentMethod paymentMethod)
    {
        var componentFactory = _factory.CreateFamilyFactory(paymentMethod);
        return componentFactory.CreateValidator(paymentMethod);
    }

    public void RegisterObserver(IPaymentObserver observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);
    }

    public void UnregisterObserver(IPaymentObserver observer)
    {
        _observers.Remove(observer);
    }

    private void NotifyObservers(PaymentEvent paymentEvent)
    {
        foreach (var observer in _observers) observer.Update(paymentEvent);
    }

    public PaymentResult ProcessPayment(PaymentOrder order)
    {
        var processor = GetProcessor(order.Method);
        var validator = GetValidator(order.Method);

        _command = new ProcessPaymentCommand(processor, validator, order);

        var result = _command.Execute();

        if (result.Success) _commandHistories.Push(_command);

        NotifyObservers(new PaymentEvent
        {
            OrderId = Guid.NewGuid(),
            Status = result.Status,
            Details = result.Message
        });

        return result;
    }

    public PaymentResult RefundPayment(PaymentOrder order)
    {
        var processor = GetProcessor(order.Method);
        var validator = GetValidator(order.Method);

        _command = new RefundPaymentCommand(processor, validator, order);

        var result = _command.Execute();

        if (result.Success) _commandHistories.Push(_command);

        NotifyObservers(new PaymentEvent
        {
            OrderId = Guid.NewGuid(),
            Status = result.Status,
            Details = result.Message
        });

        return result;
    }

    public PaymentResult Undo()
    {
        if (_commandHistories.Count == 0)
            return new PaymentResult
            {
                Success = false,
                Message = "No previous command to undo.",
                Status = PaymentStatus.Failed
            };

        var lastCommand = _commandHistories.Pop();
        var result = lastCommand.Undo();

        NotifyObservers(new PaymentEvent
        {
            OrderId = Guid.NewGuid(),
            Status = result.Status,
            Details = $"Undo: {result.Message}"
        });

        return result;
    }
}
