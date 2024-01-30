namespace CommandPattern;

public class Fan : Receiver
{

    public Fan()
    {
        Type = ReceiverType.Fan;
    }


    public override void TurnOff()
    {

        if (!State)
        {
            System.Console.WriteLine("Fan is turning off");
        }
        else
        {
            State = false;
            System.Console.WriteLine("Turning off Fan");
        }
    }

    public override void TurnOn()
    {
        if (State)
        {
            System.Console.WriteLine("Fan is turning on");
        }
        else
        {
            State = true;
            System.Console.WriteLine("Turning on Fan");
        }
    }

}
