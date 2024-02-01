namespace IteratorPattern;

public interface IAggregate<T> where T : class
{
    IIterator<T> CreateIterator();
}

public class Playlist : IAggregate<Song>
{
    private List<Song> _songs = new List<Song>();
    public void AddSong(Song song)
    {
        _songs.Add(song);
    }
    public IIterator<Song> CreateIterator()
    {
        return new PlaylistIterator(this);
    }
    public int Count => _songs.Count;
    public Song this[int index] => _songs[index];
}
