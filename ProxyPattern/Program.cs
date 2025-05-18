// See https://aka.ms/new-console-template for more information

using ProxyPattern;
using ProxyPattern.Servives;

var request = new Request(4444, new Header
{
    RequestType = "key_clock",
    Token = "access_token"
}, "Get products from web_api service", "http://localhost:4444/products?categoryId=1");

IRemote proxy = new RemoteProxy(new ServiceFactory());
Console.WriteLine(proxy.Request(request));