namespace CommandPattern.Receivers;

public class AirConditioner : Receiver
{
    public AirConditioner()
    {
        Type = ReceiverType.Fan;
    }


    public override void TurnOff()
    {
        if (!State)
        {
            Console.WriteLine("Air conditioner is turning off");
        }
        else
        {
            State = false;
            Console.WriteLine("Turning off Air conditioner");
        }
    }

    public override void TurnOn()
    {
        if (State)
        {
            Console.WriteLine("Air conditioner is turning on");
        }
        else
        {
            State = true;
            Console.WriteLine("Turning on Air conditioner");
        }
    }
}