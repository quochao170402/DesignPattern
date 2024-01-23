namespace ProxyPattern;

public interface IRemote
{
    IService TurnOn(Request request);
    void TurnOff(Request request);
}

public class Remote : IRemote
{
    public void TurnOff(Request request)
    {
        System.Console.WriteLine($"Turn off {request.Port}");
    }

    public IService TurnOn(Request request)
    {
        System.Console.WriteLine($"Turn on {request.Port}");
        if (request.Port == 3333)
        {
            return new KeyClock();
        }
        else
        {
            return new WebApi();
        }
    }
}

