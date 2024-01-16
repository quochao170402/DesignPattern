namespace CompositePattern.Car;

public class NonElectricalComponent : ICarComponent
{
    public int Price { get; set; }
    public int GetPrice()
    {
        System.Console.WriteLine($"Get price {GetType()}");
        return Price;
    }
}

public class Valve : NonElectricalComponent
{

}

public class Tire : NonElectricalComponent
{

}