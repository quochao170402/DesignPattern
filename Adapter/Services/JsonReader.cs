using Adapter.Models;

namespace Adapter.Services;

public class JsonReader
{
    public static void Execute(JsonRequest request)
    {
        Console.WriteLine($"New service execute {request.Body}");
    }
}