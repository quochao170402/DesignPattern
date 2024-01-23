// See https://aka.ms/new-console-template for more information
using ProxyPattern;

Console.WriteLine("Proxy pattern");

IBank proxy = new CreditCard(new Bank());
proxy.Deposit(1000);
proxy.Withdraw(100);