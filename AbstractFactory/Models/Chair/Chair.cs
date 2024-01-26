using AbstractFactory.Enums;

namespace AbstractFactory.Models.Chair;

public class Chair : Furniture
{
    public Chair()
    {
        Type = Enums.Type.Chair;
    }
    public override void Display()
    {
        System.Console.WriteLine($"Chair {Style.GetDisplayName()}");
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
    public VictorianChair() : base()
    {
        Style = Style.Victorian;
    }
}

public class ModernChair : Chair
{
    public ModernChair() : base()
    {
        Style = Style.Modern;
    }
}
