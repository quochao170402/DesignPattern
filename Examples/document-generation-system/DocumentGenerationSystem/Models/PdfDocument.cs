using DocumentGenerationSystem.Strategies;

namespace DocumentGenerationSystem.Models;

public class PdfHeader : IHeader
{
    private readonly string _title;

    public PdfHeader(string title)
    {
        _title = title;
    }

    public string GetContent()
    {
        return $"[PDF HEADER]: {_title.ToUpper()}";
    }
}

public class PdfSection : ISection
{
    private readonly string _content;
    private readonly IRenderingStrategy _strategy;

    public PdfSection(string content, IRenderingStrategy strategy)
    {
        _content = content;
        _strategy = strategy;
    }

    public string GetContent()
    {
        return $"[PDF SECTION]: {_strategy.Render(_content)}";
    }
}

public class PdfFooter : IFooter
{
    private readonly string _author;

    public PdfFooter(string author)
    {
        _author = author;
    }

    public string GetContent()
    {
        return $"[PDF FOOTER]: Author - {_author}";
    }
}