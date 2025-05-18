using Adapter.Models;

namespace Adapter;

public class RectangleAdapter
{
    public RectangleAdapter(Rectangle rectangle)
    {
        Rectangle = rectangle;
    }

    public Rectangle Rectangle { get; init; }

    public void Adapter(int x1, int y1, int x2, int y2)
    {
        var wight = Math.Abs(x1 - x2);
        var hight = Math.Abs(y1 - y2);

        Rectangle.X1 = x1;
        Rectangle.Y1 = y1;

        Rectangle.Width = wight;
        Rectangle.Hight = hight;
        Rectangle.Draw();
    }
}