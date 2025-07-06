namespace DocumentGenerationSystem.Strategies;

public class HtmlStrategy : IRenderingStrategy
{
    public string Render(string content)
    {
        return $"<p>{content}</p>";
    }
}