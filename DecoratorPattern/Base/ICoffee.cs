namespace DecoratorPattern.Base;

public interface ICoffee
{
    string GetDescription();
    double GetPrice();
}

public class Coffee : ICoffee
{
    public Coffee(double price)
    {
        Price = price;
    }

    public double Price { get; set; }
    public Size Size { get; set; }

    public string GetDescription()
    {
        return "Coffee";
    }

    public double GetPrice()
    {
        return Price;
    }
}

public class Freeze : ICoffee
{
    public Freeze(double price)
    {
        Price = price;
    }

    public double Price { get; set; }

    public string GetDescription()
    {
        return "Freeze";
    }

    public double GetPrice()
    {
        return Price;
    }
}