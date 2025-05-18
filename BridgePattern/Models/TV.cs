namespace BridgePattern.Models;

public class TV : IDevice
{
    public override void Display()
    {
        Console.WriteLine("TV Display");
    }

    public override void Off()
    {
        Console.WriteLine("TV off");
    }

    public override void On()
    {
        Console.WriteLine("TV on");
    }
}

public class DVD : IDevice
{
    public override void Display()
    {
        Console.WriteLine("DVD Display");
    }

    public override void Off()
    {
        Console.WriteLine("DVD off");
    }

    public override void On()
    {
        Console.WriteLine("DVD on");
    }
}