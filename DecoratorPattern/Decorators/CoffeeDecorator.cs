using DecoratorPattern.Base;

namespace DecoratorPattern.Decorators;

public abstract class CoffeeDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    protected CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }

    public virtual double GetPrice()
    {
        return _coffee.GetPrice();
    }
}

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return "Milk " + base.GetDescription();
    }

    public override double GetPrice()
    {
        return base.GetPrice() + 5;
    }
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return "Sugar " + base.GetDescription();
    }

    public override double GetPrice()
    {
        return base.GetPrice() + 2;
    }
}

public class VanillaFlavorDecorator : CoffeeDecorator
{
    public VanillaFlavorDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return "Vanilla Flavor " + base.GetDescription();
    }

    public override double GetPrice()
    {
        return base.GetPrice() + 12;
    }
}