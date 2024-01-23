namespace ProxyPattern;

public class DatabaseAccessProxy : IDatabaseAccess
{
    private IDatabaseAccess _databaseAccess;
    private readonly string _connectionString;
    private readonly string _accessKey;

    public DatabaseAccessProxy(string connectionString, string accessKey)
    {
        _accessKey = accessKey;
        _connectionString = connectionString;
    }

    public string Get(string query)
    {
        if (_databaseAccess == null)
        {
            _databaseAccess = new DatabaseAccess();
        }

        if (!canConnect())
        {
            return "Denied";
        }

        return _databaseAccess.Get(query);
    }


    private bool canConnect()
    {
        return _connectionString.Contains("mssql") && _accessKey == "access_key";
    }
}
