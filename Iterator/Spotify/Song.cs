namespace IteratorPattern.Spotify;

public class Artist
{
    public string Name { get; set; }
    public List<Song> Songs { get; set; }

    public Artist(string name, List<Song> songs)
    {
        Name = name;
        Songs = songs;
    }
}

public class Song
{
    public string Name { get; set; }
    public Artist Artist { get; set; }

    public Song(string name, Artist artist)
    {
        Name = name;
        Artist = artist;
        Artist.Songs.Add(this);
    }

    public override string ToString()
    {
        return $"Name: {Name}, Artist {Artist.Name}";
    }
}
