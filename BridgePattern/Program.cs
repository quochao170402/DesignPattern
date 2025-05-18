// See https://aka.ms/new-console-template for more information

using BridgePattern;
using BridgePattern.Shape;

Console.WriteLine("Hello, World!");

// var tv = new TV();
// var remote = new BasicRemote(tv);
// remote.Display();
// remote.TogglePower();
// remote.Display();

Color color = new Red
{
    Name = "Red"
};
Shape shape = new Square(color)
{
    Name = "Square",
    Type = ShapeType.Square,
    Hight = 100,
    Width = 20
};
IPainter painter = new Painter(shape);
var paintedShape = painter.CreateShape();
Console.WriteLine(paintedShape.GetType());
painter.Paint();