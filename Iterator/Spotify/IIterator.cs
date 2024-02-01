namespace IteratorPattern.Spotify;

public interface IIterator<T> where T : class
{
    bool HasNext();
    Song? Next();
    void Reset();
}

public class PlaylistIterator : IIterator<Song>
{
    private readonly Playlist _aggregate;
    private int _position;

    public PlaylistIterator(Playlist aggregate)
    {
        _aggregate = aggregate;
        _position = 0;
    }

    public bool HasNext()
    {
        return _position < _aggregate.Count();
    }

    public Song? Next()
    {
        if (HasNext())
        {
            return _aggregate.Get(_position++);
        }

        return null;
    }

    public void Reset()
    {
        _position = 0;
        _aggregate.Reset();
    }
}

