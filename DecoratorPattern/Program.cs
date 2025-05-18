using DecoratorPattern.Base;
using DecoratorPattern.Decorators;
using DecoratorPattern.InputStreamExample;

Console.WriteLine("Hello, World!");


ICoffee beverage = new Coffee(14);
beverage = new MilkDecorator(beverage);
beverage = new SugarDecorator(beverage);

Console.WriteLine(beverage.GetDescription());
Console.WriteLine(beverage.GetPrice());

ICoffee freeze = new Freeze(40);
freeze = new MilkDecorator(freeze);
freeze = new MilkDecorator(freeze);


Console.WriteLine(freeze.GetDescription());
var price = freeze.GetPrice();

Console.WriteLine(price);

var inputStream = new BufferedInputStream(new LowerCaseInputStream(new FileInputStream("Test Input Stream")));

Console.WriteLine(inputStream.Read());
;
// Core object
// Wrap core object by decorator -> return type of core object
// Wrap wrapped object by other decorators -> return type of core object