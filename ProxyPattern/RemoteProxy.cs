﻿using ProxyPattern.Servives;

namespace ProxyPattern;

public class RemoteProxy : IRemote
{
    private const string Token = "access_token";
    private readonly ServiceFactory _factory;

    private readonly Dictionary<int, string> dictionary;
    private IRemote _httpRemote;

    public RemoteProxy(ServiceFactory factory)
    {
        _factory = factory;

        dictionary = new Dictionary<int, string>
        {
            { 3333, "http://localhost:3333/key_clock" },
            { 4444, "http://localhost:4444/web_api" }
        };
    }

    private bool isAuthenticated(string token)
    {
        return token == Token;
    }

    public override string Request(Request request)
    {
        if (_httpRemote == null) _httpRemote = new Remote();

        var reverseResult = ReverseProxy(request.Url);

        if (reverseResult != "200") return reverseResult;

        if (_httpRemote.Service?.GetType() != typeof(KeyClock))
            if (!isAuthenticated(request.Header.Token))
                return "Denied";

        var url = string.Empty;
        if (dictionary.ContainsKey(request.Port)) url = dictionary[request.Port];
        Console.WriteLine(url);

        return _httpRemote.Request(request);
    }

    public string ReverseProxy(string url)
    {
        int port;
        if (url.Contains("3333"))
            port = 3333;
        else if (url.Contains("4444"))
            port = 4444;
        else return "404";

        var service = _factory.GetService(port);

        if (service == null) return "502";

        _httpRemote.Service = service;

        return "200";
    }
}