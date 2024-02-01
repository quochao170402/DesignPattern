using IteratorPattern.Spotify;

namespace IteratorPattern;

public static class CollectionHelper
{
    public static List<Song> ToRandomCollection(this List<Song> source)
    {
        Random random = new Random();
        List<int> candidates = Enumerable.Range(0, source.Count - 1).ToList();
        List<Song> result = new List<Song>();
        while (candidates.Count > 0)
        {
            int index = random.Next(candidates.Count);
            result.Add(source[candidates[index]]);
            candidates.RemoveAt(index);
        }

        return result;
    }
}
