namespace IteratorPattern;

public interface ISocialNetwork
{
    IProfileIterator CreateFriendsIterator(string profileId);
    IProfileIterator CreateCoworkersIterator(string profileId);
}

public class Facebook : ISocialNetwork
{
    private readonly List<Profile> _profiles;

    public Facebook(List<Profile> profiles)
    {
        if (profiles.Any())
        {
            _profiles = profiles;
        }
        else
        {
            _profiles = new List<Profile>();
        }
    }

    private Profile? FindProfileByEmail(string email)
    {
        return _profiles.Find(x => x.Email == email);
    }


    public IProfileIterator CreateCoworkersIterator(string profileId)
    {
        throw new NotImplementedException();
    }

    public IProfileIterator CreateFriendsIterator(string profileId)
    {
        throw new NotImplementedException();
    }
}

public class Instagram : ISocialNetwork
{
    public IProfileIterator CreateCoworkersIterator(string profileId)
    {
        throw new NotImplementedException();
    }

    public IProfileIterator CreateFriendsIterator(string profileId)
    {
        throw new NotImplementedException();
    }
}

public class LinkedIn : ISocialNetwork
{
    public IProfileIterator CreateCoworkersIterator(string profileId)
    {
        throw new NotImplementedException();
    }

    public IProfileIterator CreateFriendsIterator(string profileId)
    {
        throw new NotImplementedException();
    }
}
