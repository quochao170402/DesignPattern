namespace CompositePattern.Models;

public class Box : IDeliveryBox
{
    private readonly IList<IDeliveryBox> _products;

    public Box()
    {
        _products = new List<IDeliveryBox>();
    }

    public int GetPrice()
    {
        return _products.Sum(x => x.GetPrice());
    }

    public void AddProduct(IDeliveryBox product)
    {
        Console.WriteLine($"Add {product.GetType()}");
        _products.Add(product);
    }

    public void RemoveProduct(IDeliveryBox product)
    {
        Console.WriteLine($"Remove {product.GetType()}");
        _products.Remove(product);
    }
}