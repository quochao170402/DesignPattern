namespace ComboStrategyDecoratorPattern;

public interface IMoneyCalculator
{
    double Calculate(double money);
}

public class GuessedMoneyCalculator : IMoneyCalculator
{
    public double Calculate(double money) => money;
}

public class VIPMoneyCalculator : IMoneyCalculator
{
    public double DiscountPercent { get; set; } = 0.3;

    public double Calculate(double money)
    {
        return Math.Round(money * (1 - DiscountPercent), 2);
    }
}

public abstract class BaseMoneyCalculatorDecorator : IMoneyCalculator
{
    protected IMoneyCalculator Calculator { get; }

    protected BaseMoneyCalculatorDecorator(IMoneyCalculator calculator)
    {
        Calculator = calculator;
    }

    public abstract double Calculate(double money);
}

public class LoggedMoneyCalculator : BaseMoneyCalculatorDecorator
{
    public LoggedMoneyCalculator(IMoneyCalculator calculator) : base(calculator)
    {
    }

    public override double Calculate(double money)
    {
        Console.WriteLine("Calculating money...");
        var amount = Calculator.Calculate(money);
        Console.WriteLine($"Calculated amount: {amount}");
        return amount;
    }
}

public class AuthorizedMoneyCalculator : BaseMoneyCalculatorDecorator
{
    private readonly bool _isVip;

    public AuthorizedMoneyCalculator(IMoneyCalculator calculator, bool isVip) : base(calculator)
    {
        _isVip = isVip;
    }

    public override double Calculate(double money)
    {
        if (!_isVip)
        {
            throw new ArgumentException("You need to be VIP to use this calculator!");
        }

        Console.WriteLine("Authorization successful.");
        return Calculator.Calculate(money);
    }
}

public class User
{
    public IMoneyCalculator MoneyCalculator { get; private set; }

    private readonly double _amount;

    public User(double amount)
    {
        _amount = amount;
    }

    public void SetCalculator(IMoneyCalculator calculator)
    {
        MoneyCalculator = calculator;
    }

    public void Pay()
    {
        if (MoneyCalculator == null)
        {
            Console.WriteLine("No calculator set.");
            return;
        }

        var amount = MoneyCalculator.Calculate(_amount);
        Console.WriteLine($"Payment ({MoneyCalculator.GetType().Name}): {amount}");
    }
}
