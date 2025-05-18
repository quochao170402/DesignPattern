namespace IteratorPattern.Spotify;

public class Artist
{
    public Artist(string name, List<Song> songs)
    {
        Name = name;
        Songs = songs;
    }

    public string Name { get; set; }
    public List<Song> Songs { get; set; }
}

public class Song
{
    public Song(string name, Artist artist)
    {
        Name = name;
        Artist = artist;
        Artist.Songs.Add(this);
    }

    public string Name { get; set; }
    public Artist Artist { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Artist {Artist.Name}";
    }
}