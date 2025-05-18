using AbstractFactory.Enums;

namespace AbstractFactory.Models.Sofa;

public class Sofa : Furniture
{
    public override void Display()
    {
        Console.WriteLine($"Sofa {Style.GetDisplayName()}");
    }
}

public class ArtDecoSofa : Sofa
{
}

public class VictorianSofa : Sofa
{
}

public class ModernSofa : Sofa
{
}