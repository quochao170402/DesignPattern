using Adapter.Models;

namespace Adapter.Services;

public class NewVersionService
{
    public void Execute(JsonRequest request)
    {
        Console.WriteLine($"New service execute {request.Body}");
    }
}