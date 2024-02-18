using BenchmarkDotNet.Attributes;

namespace MediatorPattern;
public class Mediator : IMediator
{
    public void Create()
    {
        System.Console.WriteLine("Create");
    }


    [Benchmark]
    public void Delete()
    {
        System.Console.WriteLine("Delete");
    }


    public void Get()
    {
        System.Console.WriteLine("Get");
    }

    public void Update()
    {
        System.Console.WriteLine("Update");
    }
}
