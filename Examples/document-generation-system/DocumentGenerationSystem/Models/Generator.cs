using DocumentGenerationSystem.Factories;
using DocumentGenerationSystem.Strategies;

namespace DocumentGenerationSystem.Models;

public class Generator
{
    public IComponentFactory ComponentFactory { get; set; }
    public IRenderingStrategy Render { get; set; }
}

public class GeneratorBuilder
{
    private readonly Generator _generator = new();

    public GeneratorBuilder SetComponentFactory(IComponentFactory factory)
    {
        _generator.ComponentFactory = factory;
        return this;
    }

    public GeneratorBuilder SetRender(IRenderingStrategy render)
    {
        _generator.Render = render;
        return this;
    }

    public Generator Build()
    {
        return _generator;
    }
}