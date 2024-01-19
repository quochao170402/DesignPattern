// See https://aka.ms/new-console-template for more information
using FacadePattern;

Console.WriteLine("Hello, World!");

BankAccount account = new BankAccount()
{
    Id = "123",
    SecurityCode = "321"
};

BankFacade facade = new BankFacade(new AccountManager(), new BankMoneyManager());
facade.Deposit(account, 10000);
facade.Withdraw(account, 10000000);