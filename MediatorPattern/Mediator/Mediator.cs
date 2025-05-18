using BenchmarkDotNet.Attributes;

namespace MediatorPattern.Mediator;

public class Mediator : IMediator
{
    public void Create()
    {
        Console.WriteLine("Create");
    }


    [Benchmark]
    public void Delete()
    {
        Console.WriteLine("Delete");
    }


    public void Get()
    {
        Console.WriteLine("Get");
    }

    public void Update()
    {
        Console.WriteLine("Update");
    }
}