namespace BridgePattern;

public class TV : IDevice
{
    public override void Display()
    {
        System.Console.WriteLine($"TV Display");
    }

    public override void Off()
    {
        System.Console.WriteLine("TV off");
    }

    public override void On()
    {
        System.Console.WriteLine("TV on");

    }
}

public class DVD : IDevice
{
    public override void Display()
    {
        System.Console.WriteLine($"DVD Display");
    }

    public override void Off()
    {
        System.Console.WriteLine("DVD off");
    }

    public override void On()
    {
        System.Console.WriteLine("DVD on");

    }
}
