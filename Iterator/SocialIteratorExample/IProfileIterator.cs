namespace IteratorPattern;

public interface IProfileIterator
{
    Profile GetNext();
    bool HasMore();
}

public class FacebookIterator : IProfileIterator
{
    private readonly Facebook _facebook;
    private int _currentPosition;
    private readonly List<Profile> _cachedProfiles;

    public FacebookIterator(Facebook facebook)
    {
        _facebook = facebook;
        _currentPosition = 0;
        _cachedProfiles = new List<Profile>();
    }

    public Profile GetNext()
    {
        throw new NotImplementedException();
    }

    public bool HasMore()
    {
        throw new NotImplementedException();
    }
}