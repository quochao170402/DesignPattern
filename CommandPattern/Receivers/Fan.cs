namespace CommandPattern.Receivers;

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
            Console.WriteLine("Fan is turning off");
        }
        else
        {
            State = false;
            Console.WriteLine("Turning off Fan");
        }
    }

    public override void TurnOn()
    {
        if (State)
        {
            Console.WriteLine("Fan is turning on");
        }
        else
        {
            State = true;
            Console.WriteLine("Turning on Fan");
        }
    }
}