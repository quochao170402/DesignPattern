namespace Adapter;
public class Rectangle
{

    public int X1 { get; set; }
    public int Y1 { get; set; }
    public int Width { get; set; }
    public int Hight { get; set; }

    public void Draw()
    {
        System.Console.WriteLine($"{X1} - {Y1}, Width: {Width}, Hight: {Hight}");
    }
}
