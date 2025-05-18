namespace BridgePattern.Shape;

public abstract class Shape
{
    private readonly Color _color;

    public Shape(Color color)
    {
        _color = color;
    }

    public string Name { get; set; }
    public ShapeType Type { get; set; }

    public abstract double GetArea();

    public void Display()
    {
        Console.WriteLine($"{Name} - {Type} - {GetArea()} {_color.Name}");
    }
}

public enum ShapeType
{
    Circle,
    Square
}

public class Circle : Shape
{
    public Circle(Color color) : base(color)
    {
    }

    public double R { get; set; }

    public override double GetArea()
    {
        const double PI = 3.14;
        return PI * Math.Pow(R, 2);
    }
}

public class Square : Shape
{
    public Square(Color color) : base(color)
    {
    }

    public double Width { get; set; }
    public double Hight { get; set; }

    public override double GetArea()
    {
        return Width * Hight;
    }
}