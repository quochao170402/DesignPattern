namespace ObserverPattern.Basic;

public interface IObserver
{
    void Update(double temperature, double humidity, double pressure);
}