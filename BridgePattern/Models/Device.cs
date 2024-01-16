namespace BridgePattern;

public abstract class IDevice
{
    public bool IsPower { get; set; }
    public abstract void On();
    public abstract void Off();
    public abstract void Display();
}
