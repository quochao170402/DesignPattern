namespace DocumentGenerationSystem.Strategies;

public interface IRenderingStrategy
{
    string Render(string content);
}