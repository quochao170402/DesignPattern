# Singleton pattern
## Definition

The Singleton Pattern ensures a class has only one instance and provides a global point of access to it.

## Implementation

Here is an example of a Singleton implementation in Python:

```c#
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
        if (!IsValidUrl(url))
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
        if (!IsValidUrl(url))
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

    private bool IsValidUrl(string url)
    {
        return url.StartsWith("http") || url.StartsWith("https");

    }
}

// Program.cs
for (int i = 0; i < 5; i++)
{
    ServerPool serverPool = ServerPool.GetInstance();
}

```

## Benefits

- Controlled access to the sole instance.
- Reduced namespace pollution.
- Permits refinement of operations and representation.
- Permits a variable number of instances.

## Drawbacks

- Can be difficult to test due to global state.
- Can hide dependencies, making the code harder to understand.
- Can be a bottleneck if misused in a multithreaded environment.