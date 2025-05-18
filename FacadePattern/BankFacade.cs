using FacadePattern.Models;

namespace FacadePattern;

public class BankFacade
{
    private readonly AccountManager _accountManager;
    private readonly BankMoneyManager _bankMoneyManager;

    public BankFacade(AccountManager accountManager, BankMoneyManager bankMoneyManager)
    {
        _accountManager = accountManager;
        _bankMoneyManager = bankMoneyManager;
    }

    public void Deposit(BankAccount account, int money)
    {
        if (!_accountManager.ValidateAccount(account.Id, account.SecurityCode))
        {
            Console.WriteLine("Invalid account");
            return;
        }

        account.Amount += money;
        Console.WriteLine(account.Amount);
    }

    public void Withdraw(BankAccount account, int amount)
    {
        if (!_accountManager.ValidateAccount(account.Id, account.SecurityCode))
        {
            Console.WriteLine("Invalid account");
            return;
        }

        if (!_bankMoneyManager.IsEnoughMoney(account.Amount - amount))
        {
            Console.WriteLine("Not enough money");
            return;
        }

        account.Amount -= amount;
        Console.WriteLine(account.Amount);
    }
}