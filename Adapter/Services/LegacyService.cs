using Adapter.Models;

namespace Adapter.Services;

public class LegacyService : IService
{
    public void Execute(XMLRequest request)
    {
        Console.WriteLine("Legacy service implement execute method");
    }
}