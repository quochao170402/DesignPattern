namespace CommandPattern;

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
            System.Console.WriteLine("Air conditioner is turning off");
        }
        else
        {
            State = false;
            System.Console.WriteLine("Turning off Air conditioner");
        }
    }

    public override void TurnOn()
    {
        if (State)
        {
            System.Console.WriteLine("Air conditioner is turning on");
        }
        else
        {
            State = true;
            System.Console.WriteLine("Turning on Air conditioner");
        }
    }

}