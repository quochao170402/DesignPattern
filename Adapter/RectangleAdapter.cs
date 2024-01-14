namespace Adapter;
public class RectangleAdapter
{
    public Rectangle Rectangle { get; init; }

    public RectangleAdapter(Rectangle rectangle)
    {
        Rectangle = rectangle;
    }

    public void Adapter(int x1, int y1, int x2, int y2)
    {
        int wight = Math.Abs(x1 - x2);
        int hight = Math.Abs(y1 - y2);

        Rectangle.X1 = x1;
        Rectangle.Y1 = y1;

        Rectangle.Width = wight;
        Rectangle.Hight = hight;
        Rectangle.Draw();
    }

}
