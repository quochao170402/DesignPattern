namespace IteratorPattern.Spotify;

public static class CollectionHelper
{
    public static List<Song> ToRandomCollection(this List<Song> source)
    {
        var random = new Random();
        var candidates = Enumerable.Range(0, source.Count - 1).ToList();
        var result = new List<Song>();
        while (candidates.Count > 0)
        {
            var index = random.Next(candidates.Count);
            result.Add(source[candidates[index]]);
            candidates.RemoveAt(index);
        }

        return result;
    }
}