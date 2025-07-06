namespace DocumentGenerationSystem.Strategies;

public class MarkdownStrategy : IRenderingStrategy
{
    public string Render(string content)
    {
        return $"**{content}**";
    }
}