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
    public override void Display()
    {
        System.Console.WriteLine($"Table {this.Style.GetDisplayName()}");
    }
}

public class VictorianTable : Table
{

    public override void Display()
    {
        System.Console.WriteLine($"Table {this.Style.GetDisplayName()}");
    }
}

public class ModernTable : Table
{

    public override void Display()
    {
        System.Console.WriteLine($"Table {this.Style.GetDisplayName()}");
    }
}
