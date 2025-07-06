using DocumentGenerationSystem.Models;
using DocumentGenerationSystem.Strategies;

namespace DocumentGenerationSystem.Factories;

public interface IComponentFactory
{
    IHeader CreateHeader(string title);
    ISection CreateSection(string content, IRenderingStrategy strategy);
    IFooter CreateFooter(string author);
}