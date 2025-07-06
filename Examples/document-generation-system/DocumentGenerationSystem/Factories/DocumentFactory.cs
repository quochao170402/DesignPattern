using DocumentGenerationSystem.Models;

namespace DocumentGenerationSystem.Factories;

public interface IDocumentFactory
{
    IComponentFactory CreateComponentFactory(DocumentType type);
}

public class DocumentFactory : IDocumentFactory
{
    public IComponentFactory CreateComponentFactory(DocumentType type)
    {
        return type switch
        {
            DocumentType.Pdf => new PdfComponentFactory(),
            DocumentType.Html => new HtmlComponentFactory(),
            DocumentType.Markdown => new MarkdownComponentFactory(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}