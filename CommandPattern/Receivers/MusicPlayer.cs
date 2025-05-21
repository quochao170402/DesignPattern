namespace CommandPattern.Receivers;

public class MusicPlayer(string song)
{
    private string Song { get; set; } = song;

    public void Play()
    {
        Console.WriteLine($"Playing {Song}");
    }

    public void Pause()
    {
        Console.WriteLine("Pausing......");
    }
}