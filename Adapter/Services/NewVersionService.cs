namespace Adapter;

public class NewVersionService
{
    public void Execute(JsonRequest request)
    {
        System.Console.WriteLine($"New service execute {request.Body}");
    }
}
