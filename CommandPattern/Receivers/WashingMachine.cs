namespace CommandPattern.Receivers;

public class WashingMachine : Receiver
{
    public WashingMachine()
    {
        Type = ReceiverType.Fan;
    }


    public override void TurnOff()
    {
        if (!State)
        {
            Console.WriteLine("Washing machine is turning off");
        }
        else
        {
            State = false;
            Console.WriteLine("Turning off Washing machine");
        }
    }

    public override void TurnOn()
    {
        if (State)
        {
            Console.WriteLine("Washing machine is turning on");
        }
        else
        {
            State = true;
            Console.WriteLine("Turning on Washing machine");
        }
    }
}