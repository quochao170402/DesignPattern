namespace ProxyPattern;

public class KeyClock : IService
{
    public void Reply(Request request)
    {
        System.Console.WriteLine($"KeyClock: {request.Content}");
    }
}
