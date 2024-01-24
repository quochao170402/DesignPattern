namespace ChainOfResponsibility;

public class AuthenticationMiddleware : IMiddleware
{
    private IMiddleware _next;

    public void Handle(Request request)
    {
        if (string.IsNullOrEmpty(request.Token))
        {
            Console.WriteLine("Unauthenticated");
        }
        else
        {
            _next.Handle(request);
        }

    }

    public void SetNext(IMiddleware middleware)
    {
        _next = middleware;
    }
}
