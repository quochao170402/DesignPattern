namespace ProxyPattern.DatabaseAccessExample;

public interface IDatabaseAccess
{
    string Get(string query);
}