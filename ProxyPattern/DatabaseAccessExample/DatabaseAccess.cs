namespace ProxyPattern.DatabaseAccessExample;

public class DatabaseAccess : IDatabaseAccess
{
    public string Get(string query)
    {
        return $"Result of {query} is {query}";
    }
}