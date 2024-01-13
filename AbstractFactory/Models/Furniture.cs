using AbstractFactory.Enums;
using Type = AbstractFactory.Enums.Type;

namespace AbstractFactory.Models;

public abstract class Furniture
{
    public string Name { get; set; }
    public int Price { get; set; }
    public Style Style { get; set; }
    public Type Type { get; set; }
    public abstract void Display();
}
