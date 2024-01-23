namespace ProxyPattern;
public class ServiceFactory
{
    private readonly Dictionary<int, IService> _services;

    public ServiceFactory()
    {
        _services = new Dictionary<int, IService>(){
            {3333, new KeyClock()},
            {4444, new WebApi()}
        };
    }

    public IService? GetService(int port)
    {

        if (_services.ContainsKey(port))
        {
            return _services[port];
        }

        return null;
    }
}
