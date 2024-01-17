using DecoratorPattern;

Console.WriteLine("Hello, World!");

var coffee = new MilkDecorator(
                new SugarDecorator(
                    new VanillaFlavorDecorator(
                        new SugarDecorator(
                            new Coffee(10)))));

System.Console.WriteLine(coffee.GetDescription());
System.Console.WriteLine(coffee.GetPrice());