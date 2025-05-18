// See https://aka.ms/new-console-template for more information

using FacadePattern;
using FacadePattern.Models;

Console.WriteLine("Hello, World!");

BankAccount account = new()
{
    Id = "1213",
    SecurityCode = "321"
};

BankFacade facade = new(new AccountManager(), new BankMoneyManager());
facade.Deposit(account, 1000);
facade.Withdraw(account, 10000000);