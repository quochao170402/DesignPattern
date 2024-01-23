﻿namespace ProxyPattern;

public class WebApi : IService
{
    public string Reply(Request request)
    {
        return $"Web api {request.Content}";
    }
}
