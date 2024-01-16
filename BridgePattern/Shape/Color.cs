namespace BridgePattern;
public abstract class Color
{
    public string Name { get; set; }
    public abstract void Paint();
}

public class Red : Color
{
    public override void Paint()
    {
        System.Console.WriteLine("Red");
    }
}

public class Blue : Color
{
    public override void Paint()
    {
        System.Console.WriteLine("Blue");
    }
}