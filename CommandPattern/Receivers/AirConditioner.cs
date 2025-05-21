namespace CommandPattern.Receivers;

public class AirConditioner
{
    private const int MaxSpeed = 3;
    private int _currentSpeed;

    public void High()
    {
        if (_currentSpeed < MaxSpeed) _currentSpeed++;
        else Console.WriteLine("Maximum speed");

        Console.WriteLine($"High speed: {_currentSpeed}");
    }

    public void Low()
    {
        if (_currentSpeed > 0) _currentSpeed--;
        else Console.WriteLine("Minimum speed");

        Console.WriteLine($"Low speed: {_currentSpeed}");
    }
}