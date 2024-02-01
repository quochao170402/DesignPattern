namespace IteratorPattern;

public interface IIterator<T> where T : class
{
    bool HasNext();
    T Next();
}

public class PlaylistIterator : IIterator<Song>
{
    private readonly Playlist _playlist;
    private int _index = 0;
    public PlaylistIterator(Playlist playlist)
    {
        _playlist = playlist;
    }
    public bool HasNext()
    {
        return _index < _playlist.Count;
    }
    public Song Next()
    {
        return _playlist[_index++];
    }
}
