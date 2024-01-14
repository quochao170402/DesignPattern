// See https://aka.ms/new-console-template for more information

using Adapter;

Console.WriteLine("Hello, World!");
var line = new Line()
{
    X1 = 1,
    Y1 = 2,
    X2 = 3,
    Y2 = 4
};
line.Draw();

var adapter = new RectangleAdapter(new Rectangle());
adapter.Adapter(1, 2, 3, 4);