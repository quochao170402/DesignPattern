namespace DecoratorPattern;
public interface ICoffee
{
    string GetDescription();
    double GetPrice();
}

public class Coffee : ICoffee
{
    public double Price { get; set; }
    public Coffee(double price)
    {
        Price = price;
    }
    public string GetDescription()
    {
        return "Coffee";
    }

    public double GetPrice()
    {
        return Price;
    }
}
