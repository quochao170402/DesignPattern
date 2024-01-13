using AbstractFactory.Enums;

namespace AbstractFactory.Models.Table;

public class Table : Furniture
{
    public override void Display()
    {
        System.Console.WriteLine($"Table {Style.GetDisplayName()}");
    }
}

public class ArtDecoTable : Table
{
}

public class VictorianTable : Table
{
}

public class ModernTable : Table
{
}
