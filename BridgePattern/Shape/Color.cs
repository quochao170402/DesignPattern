namespace BridgePattern.Shape;

public abstract class Color
{
    public string Name { get; set; }
    public abstract void Paint();
}

public class Red : Color
{
    public override void Paint()
    {
        Console.WriteLine("Red");
    }
}

public class Blue : Color
{
    public override void Paint()
    {
        Console.WriteLine("Blue");
    }
}