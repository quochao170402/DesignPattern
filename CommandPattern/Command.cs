using CommandPattern.Receivers;

namespace CommandPattern;

public class Command : ICommand
{
    private readonly Receiver _receiver;

    public Command(Receiver receiver)
    {
        _receiver = receiver;
    }

    public void Execute()
    {
        _receiver.TurnOn();
    }

    public void Undo()
    {
        _receiver.TurnOff();
    }
}