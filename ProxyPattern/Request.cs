namespace ProxyPattern;

public class Request
{
    public string Content { get; set; }
    public Header Header { get; set; }
    public int Port { get; set; }

    public Request(int port, Header header, string content)
    {
        Port = port;
        Header = header;
        Content = content;
    }


}

public class Header
{
    public string RequestType { get; set; }
    public string Token { get; set; }
}
