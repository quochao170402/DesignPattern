namespace CommandPattern.Receivers;

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
            Console.WriteLine("TV is turning off");
        }
        else
        {
            State = false;
            Console.WriteLine("Turning off TV");
        }
    }

    public override void TurnOn()
    {
        if (State)
        {
            Console.WriteLine("TV is turning on");
        }
        else
        {
            State = true;
            Console.WriteLine("Turning on TV");
        }
    }
}