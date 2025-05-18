namespace IteratorPattern.Collection;

public interface IIterator<T>
{
    bool HasNext();
    T? GetNext();
    void Reset();
    bool HasPrevious();
    T? GetPrevious();
}

public class Iterator<T> : IIterator<T>
{
    private readonly CustomList<T> _source;

    public Iterator(CustomList<T> source)
    {
        _source = source;
        Position = 0;
    }

    public int Position { get; private set; }

    public T? GetNext()
    {
        if (HasNext()) return _source.Get(Position++);

        return default;
    }

    public bool HasNext()
    {
        return Position < _source.Count;
    }

    public void Reset()
    {
        Position = 0;
    }

    public bool HasPrevious()
    {
        return Position > 0 && Position < _source.Count;
    }

    public T? GetPrevious()
    {
        if (HasPrevious()) return _source.Get(Position--);

        return default;
    }
}