namespace BridgePattern;

public interface IPainter
{
    Shape.Shape CreateShape();
    void Paint();
}

public class Painter : IPainter
{
    private readonly Shape.Shape _shape;

    public Painter(Shape.Shape shape)
    {
        _shape = shape;
    }

    public Shape.Shape CreateShape()
    {
        return _shape;
    }

    public void Paint()
    {
        _shape.Display();
    }
}