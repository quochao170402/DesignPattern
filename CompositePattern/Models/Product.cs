namespace CompositePattern;

public class Product : IDeliveryBox
{
    public int Price { get; set; }
    public int GetPrice()
    {
        Console.WriteLine($"Get price of {this.GetType()}");
        return Price;
    }
}
