using DocumentGenerationSystem.Models;
using DocumentGenerationSystem.Strategies;

namespace DocumentGenerationSystem.Factories;

public interface IRenderFactory
{
    IRenderingStrategy CreateRender(DocumentType type);
}

public class RenderFactory : IRenderFactory
{
    public IRenderingStrategy CreateRender(DocumentType type)
    {
        return type switch
        {
            DocumentType.Pdf => new PdfStrategy(),
            DocumentType.Html => new HtmlStrategy(),
            DocumentType.Markdown => new MarkdownStrategy(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}