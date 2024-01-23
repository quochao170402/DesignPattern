// See https://aka.ms/new-console-template for more information
using ProxyPattern;

Request request = new Request(4444, new Header()
{
    RequestType = "key_clock",
    Token = "access_token"
}, "Get User by Token", "http://localhost:4444/key_clock");

IRemote proxy = new RemoteProxy(new ServiceFactory());
System.Console.WriteLine(proxy.Request(request));