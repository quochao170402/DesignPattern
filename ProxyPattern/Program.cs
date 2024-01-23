// See https://aka.ms/new-console-template for more information
using ProxyPattern;

Request request = new Request(3333, new Header()
{
    RequestType = "key_clock",
    Token = "token"
}, "http://localhost:3333/key_clock");

IRemote proxy = new RemoteProxy();
IService service = proxy.TurnOn(request);
service.Reply(request);
proxy.TurnOff(request);