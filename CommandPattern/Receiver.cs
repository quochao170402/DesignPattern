namespace CommandPattern;

public class Receiver
{
    public bool State { get; set; } = false;
    public void TurnOn()
    {
        if (State)
        {
            System.Console.WriteLine("Receive is turning on");
        }
        else
        {
            State = true;
            System.Console.WriteLine("Turn on");
        }
    }

    public void TurnOff()
    {
        if (!State)
        {
            System.Console.WriteLine("Receive is turning off");
        }
        else
        {
            State = false;
            System.Console.WriteLine("Turn off");
        }
    }
}
