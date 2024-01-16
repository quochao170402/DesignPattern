namespace CompositePattern.Car;

public class CarComponent : ICarComponent
{
    private readonly List<ICarComponent> _components = new();

    public int GetPrice()
    {
        System.Console.WriteLine($"Get price {GetType()}");
        return _components.Sum(component => component.GetPrice());
    }

    public void AddComponent(ICarComponent component)
    {
        System.Console.WriteLine($"Add {component.GetType()}");
        _components.Add(component);
    }

    public void RemoveComponent(ICarComponent component)
    {
        System.Console.WriteLine($"Remove {component.GetType()}");
        _components.Remove(component);
    }
}
