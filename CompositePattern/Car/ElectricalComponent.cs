namespace CompositePattern.Car;

public class ElectricalComponent : ICarComponent
{
    public int Price { get; set; }
    public int GetPrice()
    {
        System.Console.WriteLine($"Get price {GetType()}");
        return Price;
    }
}

public class Chip : ElectricalComponent
{

}

public class Screen : ElectricalComponent
{

}
