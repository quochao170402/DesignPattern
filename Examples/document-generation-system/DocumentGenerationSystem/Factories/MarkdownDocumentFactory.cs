using DocumentGenerationSystem.Models;
using DocumentGenerationSystem.Strategies;

namespace DocumentGenerationSystem.Factories;

public class MarkdownComponentFactory : IComponentFactory
{
    public IHeader CreateHeader(string title)
    {
        return new MarkdownHeader(title);
    }

    public ISection CreateSection(string content, IRenderingStrategy strategy)
    {
        return new MarkdownSection(content, strategy);
    }

    public IFooter CreateFooter(string author)
    {
        return new MarkdownFooter(author);
    }
}