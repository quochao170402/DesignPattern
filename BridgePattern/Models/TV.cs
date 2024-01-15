namespace BridgePattern;

public class TV : IDevice
{
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
