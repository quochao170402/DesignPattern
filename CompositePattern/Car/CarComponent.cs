namespace CompositePattern.Car;

public class CarComponent : ICarComponent
{
    private readonly List<ICarComponent> _components = new();

    public int GetPrice()
    {
        Console.WriteLine($"Get price {GetType()}");
        return _components.Sum(component => component.GetPrice());
    }

    public void AddComponent(ICarComponent component)
    {
        Console.WriteLine($"Add {component.GetType()}");
        _components.Add(component);
    }

    public void RemoveComponent(ICarComponent component)
    {
        Console.WriteLine($"Remove {component.GetType()}");
        _components.Remove(component);
    }
}