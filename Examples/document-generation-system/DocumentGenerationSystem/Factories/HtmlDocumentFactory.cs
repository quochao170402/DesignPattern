using DocumentGenerationSystem.Models;
using DocumentGenerationSystem.Strategies;

namespace DocumentGenerationSystem.Factories;

public class HtmlComponentFactory : IComponentFactory
{
    public IHeader CreateHeader(string title)
    {
        return new HtmlHeader(title);
    }

    public ISection CreateSection(string content, IRenderingStrategy strategy)
    {
        return new HtmlSection(content, strategy);
    }

    public IFooter CreateFooter(string author)
    {
        return new HtmlFooter(author);
    }
}