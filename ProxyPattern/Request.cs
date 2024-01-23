namespace ProxyPattern;

public class Request
{
    public string Content { get; set; }
    public Header Header { get; set; }
    public int Port { get; set; }
    public string Url { get; set; }

    public Request(int port, Header header, string content, string url)
    {
        Port = port;
        Header = header;
        Content = content;
        Url = url;
    }


}

public class Header
{
    public string RequestType { get; set; }
    public string Token { get; set; }
}
