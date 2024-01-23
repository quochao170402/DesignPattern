namespace ProxyPattern;

public class DatabaseAccess : IDatabaseAccess
{
    public DatabaseAccess()
    {
    }

    public string Get(string query)
    {
        return $"Result of {query} is {query}";
    }
}
