// See https://aka.ms/new-console-template for more information

using ComboStrategyDecoratorPattern;

Console.WriteLine("Hello, World!");

var user = new User(1234);

IMoneyCalculator calculator = new GuessedMoneyCalculator();
calculator = new LoggedMoneyCalculator(calculator);
calculator = new AuthorizedMoneyCalculator(calculator, true);

user.SetCalculator(calculator);

user.Pay();
