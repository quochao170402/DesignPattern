namespace ProxyPattern;

public class RemoteProxy : IRemote
{
    private IRemote _httpRemote;


    private const string Token = "access_token";

    public void TurnOff(Request request)
    {
        if (isAuthenticated(request.Header.Token))
        {
            System.Console.WriteLine("Denied");
        }

        if (_httpRemote == null)
        {
            _httpRemote = new Remote();
        }

        System.Console.WriteLine("Proxy turn off remote");
    }

    public IService TurnOn(Request request)
    {
        if (isAuthenticated(request.Header.Token))
        {
            System.Console.WriteLine("Denied");
        }

        if (_httpRemote == null)
        {
            _httpRemote = new Remote();
        }

        return _httpRemote.TurnOn(request);
    }

    private bool isAuthenticated(string token)
    {
        return token == Token;
    }
}
