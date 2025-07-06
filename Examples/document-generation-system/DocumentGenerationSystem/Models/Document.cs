namespace DocumentGenerationSystem.Models;

public class Document
{
    public required DocumentType Type { get; set; }
    public IHeader Header { get; set; }
    public List<ISection> Sections { get; } = [];
    public IFooter Footer { get; set; }

    public void Display()
    {
        Console.WriteLine(Header.GetContent());
        foreach (var section in Sections) Console.WriteLine(section.GetContent());
        Console.WriteLine(Footer.GetContent());
    }
}

public interface IHeader
{
    string GetContent();
}

public interface ISection
{
    string GetContent();
}

public interface IFooter
{
    string GetContent();
}