using DocumentGenerationSystem.Models;
using DocumentGenerationSystem.Strategies;

namespace DocumentGenerationSystem.Factories;

public class PdfComponentFactory : IComponentFactory
{
    public IHeader CreateHeader(string title)
    {
        return new PdfHeader(title);
    }

    public ISection CreateSection(string content, IRenderingStrategy strategy)
    {
        return new PdfSection(content, strategy);
    }

    public IFooter CreateFooter(string author)
    {
        return new PdfFooter(author);
    }
}