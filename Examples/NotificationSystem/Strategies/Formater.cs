namespace NotificationSystem.Strategies;

public interface IFormater
{
    string Format(string message);
}

public class AlertFormater : IFormater
{
    public string Format(string message)
    {
        return $"Alert format: {message}";
    }
}

public class PromoFormat : IFormater
{
    public string Format(string message)
    {
        return $"Promotion format: {message}";
    }
}