namespace ChainOfResponsibility;

public interface IMiddleware
{
    void SetNext(IMiddleware middleware);
    void Handle(Request request);
}