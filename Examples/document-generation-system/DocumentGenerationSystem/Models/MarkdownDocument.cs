using DocumentGenerationSystem.Strategies;

namespace DocumentGenerationSystem.Models;

public class MarkdownHeader : IHeader
{
    private readonly string _title;

    public MarkdownHeader(string title)
    {
        _title = title;
    }

    public string GetContent()
    {
        return $"# {_title}";
    }
}

public class MarkdownSection : ISection
{
    private readonly string _content;
    private readonly IRenderingStrategy _strategy;

    public MarkdownSection(string content, IRenderingStrategy strategy)
    {
        _content = content;
        _strategy = strategy;
    }

    public string GetContent()
    {
        return _strategy.Render(_content);
    }
}

public class MarkdownFooter : IFooter
{
    private readonly string _author;

    public MarkdownFooter(string author)
    {
        _author = author;
    }

    public string GetContent()
    {
        return $"*Author: {_author}*";
    }
}