namespace SingletonPattern;

public class ServerPool
{
    private readonly List<string> _urls;

    private ServerPool()
    {
        _urls = new List<string>();
    }

    private static ServerPool Instance { get; } = new();

    public static ServerPool GetInstance() => Instance;

    public bool Add(string url)
    {
        if (!IsValidUrl(url)) return false;

        if (_urls.Contains(url)) return false;

        _urls.Add(url);
        return true;
    }

    public bool Remove(string url)
    {
        if (!IsValidUrl(url)) return false;

        if (_urls.Contains(url)) return false;

        _urls.Remove(url);
        return true;
    }

    private static bool IsValidUrl(string url)
    {
        return url.StartsWith("http") || url.StartsWith("https");
    }
}