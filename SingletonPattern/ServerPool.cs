namespace SingletonPattern;

public class ServerPool
{
    private readonly List<string> _urls;

    private static ServerPool? Instance
    {
        get;
        set;
    }

    private ServerPool()
    {
        _urls = new List<string>();
    }

    public static ServerPool GetInstance()
    {
        if (Instance == null)
        {
            System.Console.WriteLine("Create new server instance");
            Instance = new ServerPool();
        }

        return Instance;
    }

    public bool Add(string url)
    {
        if (!isValidUrl(url))
        {
            return false;
        }

        if (_urls.Contains(url))
        {
            return false;
        }

        _urls.Add(url);
        return true;
    }

    public bool Remove(string url)
    {
        if (!isValidUrl(url))
        {
            return false;
        }

        if (_urls.Contains(url))
        {
            return false;
        }

        _urls.Remove(url);
        return true;
    }

    private bool isValidUrl(string url)
    {
        return url.StartsWith("http") || url.StartsWith("https");

    }
}
