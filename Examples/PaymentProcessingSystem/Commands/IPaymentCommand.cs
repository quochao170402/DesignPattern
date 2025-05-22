using PaymentProcessingSystem.Components;
using PaymentProcessingSystem.Models;

namespace PaymentProcessingSystem.Commands;

public interface IPaymentCommand
{
    PaymentResult Execute();
    PaymentResult Undo();
}

public class ProcessPaymentCommand : IPaymentCommand
{
    private readonly PaymentOrder _order;
    private readonly IPaymentProcessor _processor;
    private readonly IPaymentValidator _validator;
    private PaymentResult _result = PaymentResult.None;

    public ProcessPaymentCommand(IPaymentProcessor processor, IPaymentValidator validator, PaymentOrder order)
    {
        _processor = processor;
        _order = order;
        _validator = validator;
    }

    public PaymentResult Execute()
    {
        if (!_validator.Validate(_order))
        {
            _result = new PaymentResult
            {
                Success = false,
                Message = "Payment validation failed.",
                Status = PaymentStatus.Failed
            };
            return _result;
        }

        _result = _processor.ProcessPayment(_order);
        return _result;
    }

    public PaymentResult Undo()
    {
        if (_result is not { Success: true })
            return new PaymentResult
            {
                Success = false,
                Status = PaymentStatus.Failed,
                Message = "Cannot undo payment that failed or was not executed."
            };

        _result = _processor.RefundPayment(_order);
        return _result;
    }
}

public class RefundPaymentCommand : IPaymentCommand
{
    private readonly PaymentOrder _order;
    private readonly IPaymentProcessor _processor;
    private readonly IPaymentValidator _validator;
    private PaymentResult _result = PaymentResult.None;

    public RefundPaymentCommand(IPaymentProcessor processor, IPaymentValidator validator, PaymentOrder order)
    {
        _processor = processor;
        _order = order;
        _validator = validator;
    }

    public PaymentResult Execute()
    {
        if (!_validator.Validate(_order))
        {
            _result = new PaymentResult
            {
                Success = false,
                Status = PaymentStatus.Failed,
                Message = "Refund validation failed."
            };
            return _result;
        }

        _result = _processor.RefundPayment(_order);
        return _result;
    }

    public PaymentResult Undo()
    {
        if (_result is not { Success: true })
            return new PaymentResult
            {
                Success = false,
                Status = PaymentStatus.Failed,
                Message = "Cannot undo refund that failed or was not executed."
            };

        _result = _processor.ProcessPayment(_order);
        return _result;
    }
}