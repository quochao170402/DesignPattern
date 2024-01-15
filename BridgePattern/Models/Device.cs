namespace BridgePattern;

public interface IDevice
{
    string Name { get; set; }
    public bool IsOn { get; set; }
    void On();
    void Off();
    void Display();
}
