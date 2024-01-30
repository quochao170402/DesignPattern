namespace CommandPattern;

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
            System.Console.WriteLine("Washing machine is turning off");
        }
        else
        {
            State = false;
            System.Console.WriteLine("Turning off Washing machine");
        }
    }

    public override void TurnOn()
    {
        if (State)
        {
            System.Console.WriteLine("Washing machine is turning on");
        }
        else
        {
            State = true;
            System.Console.WriteLine("Turning on Washing machine");
        }
    }

}