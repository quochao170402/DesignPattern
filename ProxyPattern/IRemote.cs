namespace ProxyPattern;

public abstract class IRemote
{
    public IService? Service { get; set; }

    public abstract string Request(Request request);

}

public class Remote : IRemote
{
    public override string Request(Request request)
    {
        if (Service == null)
        {
            return "404";
        }

        return Service.Reply(request);
    }
}

