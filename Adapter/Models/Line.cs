namespace Adapter.Models;

public class Line
{
    public int X1 { get; set; }
    public int Y1 { get; set; }
    public int X2 { get; set; }
    public int Y2 { get; set; }

    public void Draw()
    {
        Console.WriteLine($"X1: {X1} - Y1: {Y1} - X2: {X2} - Y2: {Y2}");
    }
}