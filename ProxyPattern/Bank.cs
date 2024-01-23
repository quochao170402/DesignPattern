namespace ProxyPattern;

public interface IBank
{
    void Deposit(int amount);
    void Withdraw(int amount);
}

public class Bank : IBank
{
    public void Deposit(int amount)
    {
        System.Console.WriteLine($"Bank deposit {amount}");
    }

    public void Withdraw(int amount)
    {
        System.Console.WriteLine($"Bank withdraw {amount}");
    }
}

public class CreditCard : IBank
{
    private readonly IBank _bank;


    public CreditCard(IBank bank)
    {
        _bank = bank;
    }

    public void Deposit(int amount)
    {
        System.Console.WriteLine("Validate bank account");
        _bank.Deposit(amount);
    }

    public void Withdraw(int amount)
    {
        System.Console.WriteLine("Validate bank account");
        System.Console.WriteLine("Validate total amount");
        _bank.Withdraw(amount);
    }
}