using Adapter.Models;

namespace Adapter.Services;

public class XMLReader : IReader
{
    public void Execute(XMLRequest request)
    {
        Console.WriteLine("Legacy service implement execute method");
    }
}