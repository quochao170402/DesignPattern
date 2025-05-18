using AbstractFactory.Enums;
using Type = AbstractFactory.Enums.Type;

namespace AbstractFactory.Models.Chair;

public class Chair : Furniture
{
    public Chair()
    {
        Type = Type.Chair;
    }

    public override void Display()
    {
        Console.WriteLine($"Chair {Style.GetDisplayName()}");
    }
}

public class ArtDecoChair : Chair
{
    public ArtDecoChair()
    {
        Style = Style.ArtDeco;
    }
}

public class VictorianChair : Chair
{
    public VictorianChair()
    {
        Style = Style.Victorian;
    }
}

public class ModernChair : Chair
{
    public ModernChair()
    {
        Style = Style.Modern;
    }
}