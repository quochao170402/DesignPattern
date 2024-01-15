namespace BridgePattern;

public class TV : IDevice
{
    public bool IsOn
    {
        get => IsOn; set => IsOn = value;
    }
    public void Display()
    {
        System.Console.WriteLine($"TV Display");
    }

    public void Off()
    {
        System.Console.WriteLine("TV off");
    }

    public void On()
    {
        System.Console.WriteLine("TV on");
    }
}

public class DVD : IDevice
{
    public bool IsOn
    {
        get => IsOn; set => IsOn = value;
    }
    public void Display()
    {
        System.Console.WriteLine($"DVD Display");
    }

    public void Off()
    {
        System.Console.WriteLine("DVD off");
    }

    public void On()
    {
        System.Console.WriteLine("DVD on");
    }
}
