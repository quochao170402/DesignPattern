namespace ProxyPattern;

public class WebApi : IService
{
    public void Reply(Request request)
    {
        System.Console.WriteLine($"Web api {request.Content}");
    }
}
