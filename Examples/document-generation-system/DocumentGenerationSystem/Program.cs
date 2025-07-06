// See https://aka.ms/new-console-template for more information

using DocumentGenerationSystem.Factories;
using DocumentGenerationSystem.Models;

Console.WriteLine("Hello, World!");

var document = new Document
{
    Type = DocumentType.Pdf
};

var generatorFactory = new DocumentFactory();

var componentFactory = generatorFactory.CreateComponentFactory(document.Type);
var renderStrategy = new RenderFactory().CreateRender(document.Type);


var generator = new GeneratorBuilder().SetComponentFactory(componentFactory)
    .SetRender(renderStrategy)
    .Build();

document.Header = generator.ComponentFactory.CreateHeader("Document generation");

document.Sections.Add(generator.ComponentFactory.CreateSection("Hello world 1", generator.Render));
document.Sections.Add(generator.ComponentFactory.CreateSection("Hello world 2", generator.Render));
document.Sections.Add(generator.ComponentFactory.CreateSection("Hello world 3", generator.Render));

document.Footer = generator.ComponentFactory.CreateFooter("Bui Quoc Hao");

document.Display();