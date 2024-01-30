namespace CommandPattern;

public class TV : Receiver
{
    public TV()
    {
        Type = ReceiverType.TV;
    }


    public override void TurnOff()
    {

        if (!State)
        {
            System.Console.WriteLine("TV is turning off");
        }
        else
        {
            State = false;
            System.Console.WriteLine("Turning off TV");
        }
    }

    public override void TurnOn()
    {
        if (State)
        {
            System.Console.WriteLine("TV is turning on");
        }
        else
        {
            State = true;
            System.Console.WriteLine("Turning on TV");
        }
    }
}
