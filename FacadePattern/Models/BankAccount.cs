namespace FacadePattern.Models;

public class BankAccount
{
    public string Id { get; set; }
    public string SecurityCode { get; set; }
    public int Amount { get; set; }
}

public class AccountManager
{
    public bool ValidateAccount(string id, string securityCode)
    {
        if (id == "123" && securityCode == "321") return true;

        return false;
    }
}

public class BankMoneyManager
{
    public void Deposit(int amount)
    {
        Console.WriteLine($"Deposit {amount}");
    }

    public void Withdraw(int amount)
    {
        Console.WriteLine($"Withdraw {amount}");
    }

    public bool IsEnoughMoney(int amount)
    {
        if (amount > 0) return true;
        return false;
    }
}