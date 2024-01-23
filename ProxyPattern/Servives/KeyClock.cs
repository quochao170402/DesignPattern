﻿namespace ProxyPattern;

public class KeyClock : IService
{
    public string Reply(Request request)
    {
        return $"KeyClock: {request.Content}";
    }
}
