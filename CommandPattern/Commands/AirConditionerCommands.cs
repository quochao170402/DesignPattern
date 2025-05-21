using CommandPattern.Receivers;

namespace CommandPattern.Commands;

public class AirConditionerHighCommand(AirConditioner airConditioner) : ICommand
{
    public void Execute()
    {
        airConditioner.High();
    }

    public void Undo()
    {
        airConditioner.Low();
    }
}

public class AirConditionerLowCommand(AirConditioner airConditioner) : ICommand
{
    public void Execute()
    {
        airConditioner.Low();
    }

    public void Undo()
    {
        airConditioner.High();
    }
}