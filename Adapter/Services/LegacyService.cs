namespace Adapter;

public class LegacyService : IService
{
    public void Execute(XMLRequest request)
    {
        System.Console.WriteLine("Legacy service implement execute method");
    }
}
