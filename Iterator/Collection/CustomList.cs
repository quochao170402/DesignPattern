using System.Collections;

namespace IteratorPattern;

public class CustomList<T>
{
    private readonly List<T> _source;
    public int Count { get => _source.Count; }

    public CustomList(List<T> source)
    {
        _source = source;
    }

    public CustomList()
    {
        _source = new List<T>();
    }

    public void Add(T element)
    {
        _source.Add(element);
    }

    public void Remove(T element)
    {
        _source.Remove(element);
    }

    public T Get(int index)
    {
        return _source[index];
    }

    public IIterator<T> Iterator()
    {
        return new Iterator<T>(this);
    }
}
