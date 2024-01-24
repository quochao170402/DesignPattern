namespace ChainOfResponsibility;

public class PermissionMiddleware : IMiddleware
{
    private IMiddleware _next;
    public void Handle(Request request)
    {
        if (request.Token.Contains("create"))
        {
            Console.WriteLine("DONE");
        }
        else
        {
            Console.WriteLine("DENIED");
        }
    }

    public void SetNext(IMiddleware middleware)
    {
        _next = middleware;
    }
}
