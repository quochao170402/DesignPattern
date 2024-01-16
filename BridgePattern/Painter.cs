namespace BridgePattern;
public interface IPainter
{
    Shape CreateShape();
    void Paint();
}

public class Painter : IPainter
{
    private readonly Shape _shape;
    public Painter(Shape shape)
    {
        _shape = shape;
    }
    public Shape CreateShape()
    {
        return _shape;
    }

    public void Paint()
    {
        _shape.Display();
    }
}
