using AbstractFactory.Enums;

namespace AbstractFactory.Models.Chair;

public class Chair : Furniture
{
    public override void Display()
    {
        System.Console.WriteLine($"Chair {Style.GetDisplayName()}");
    }
}

public class ArtDecoChair : Chair
{
}

public class VictorianChair : Chair
{
}

public class ModernChair : Chair
{
}
