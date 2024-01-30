namespace CommandPattern;

public abstract class Receiver
{
    public ReceiverType Type { get; set; }
    public bool State { get; set; } = false;

    public abstract void TurnOn();
    public abstract void TurnOff();
}
