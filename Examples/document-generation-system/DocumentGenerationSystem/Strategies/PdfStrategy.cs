namespace DocumentGenerationSystem.Strategies;

public class PdfStrategy : IRenderingStrategy
{
    public string Render(string content)
    {
        return content;
    }
}