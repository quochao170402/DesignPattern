namespace IteratorPattern.Spotify;

public interface IAggregate<T> where T : class
{
    IIterator<T> CreateIterator();
}

public class Playlist : IAggregate<Song>
{
    private List<Song> _cachedSongs;

    public Playlist(List<Song> songs, bool isRandom)
    {
        Songs = songs;
        IsRandom = isRandom;
        if (isRandom)
            _cachedSongs = RandomPlay();
        else
            _cachedSongs = Songs;
    }

    public List<Song> Songs { get; set; }
    public bool IsRandom { get; init; }


    public IIterator<Song> CreateIterator()
    {
        return new PlaylistIterator(this);
    }

    public List<Song> RandomPlay()
    {
        return Songs.ToRandomCollection();
    }

    public Song Get(int index)
    {
        return _cachedSongs[index];
    }

    public int Count()
    {
        return _cachedSongs.Count;
    }

    public void Reset()
    {
        Console.WriteLine("Reset");
        _cachedSongs = IsRandom ? RandomPlay() : Songs;
    }
}