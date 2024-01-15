namespace BridgePattern;

public interface IDevice
{
    public bool IsOn { get; set; }
    void On();
    void Off();
    void Display();
}
