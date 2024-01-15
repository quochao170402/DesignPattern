namespace BridgePattern;

public interface IRemote
{
    void TogglePower();
    void Display();
}

public class BasicRemote : IRemote
{
    private readonly IDevice _device;

    public BasicRemote(IDevice device)
    {
        _device = device;
    }

    public void Display()
    {
        _device.Display();
    }

    public void TogglePower()
    {
        if (_device.IsOn)
        {
            _device.IsOn = false;
            _device.Off();
        }
        else
        {
            _device.IsOn = true;
            _device.On();
        }
    }
}
