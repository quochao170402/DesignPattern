namespace ChainOfResponsibility;

public class AuthorizationMiddleware : IMiddleware
{
    private IMiddleware _next;

    public void Handle(Request request)
    {
        if (!request.Token.Contains("token"))
        {
            Console.WriteLine("Unauthorized");
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
