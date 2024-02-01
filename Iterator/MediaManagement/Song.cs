namespace IteratorPattern;

public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public Song(string title, string artist)
    {
        Title = title;
        Artist = artist;
    }
    public override string ToString() => $"{Title} by {Artist}";
}
