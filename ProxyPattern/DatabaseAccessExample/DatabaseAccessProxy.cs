namespace ProxyPattern.DatabaseAccessExample;

public class DatabaseAccessProxy : IDatabaseAccess
{
    private readonly string _accessKey;
    private readonly string _connectionString;
    private IDatabaseAccess _databaseAccess;

    public DatabaseAccessProxy(string connectionString, string accessKey)
    {
        _accessKey = accessKey;
        _connectionString = connectionString;
    }

    public string Get(string query)
    {
        if (_databaseAccess == null) _databaseAccess = new DatabaseAccess();

        if (!canConnect()) return "Denied";

        return _databaseAccess.Get(query);
    }


    private bool canConnect()
    {
        return _connectionString.Contains("mssql") && _accessKey == "access_key";
    }
}