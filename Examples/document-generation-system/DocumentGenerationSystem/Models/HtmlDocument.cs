using DocumentGenerationSystem.Strategies;

namespace DocumentGenerationSystem.Models;

public class HtmlHeader : IHeader
{
    private readonly string _title;

    public HtmlHeader(string title)
    {
        _title = title;
    }

    public string GetContent()
    {
        return $"<h1>{_title}</h1>";
    }
}

public class HtmlSection : ISection
{
    private readonly string _content;
    private readonly IRenderingStrategy _strategy;

    public HtmlSection(string content, IRenderingStrategy strategy)
    {
        _content = content;
        _strategy = strategy;
    }

    public string GetContent()
    {
        return _strategy.Render(_content);
    }
}

public class HtmlFooter : IFooter
{
    private readonly string _author;

    public HtmlFooter(string author)
    {
        _author = author;
    }

    public string GetContent()
    {
        return $"<footer><em>Author: {_author}</em></footer>";
    }
}