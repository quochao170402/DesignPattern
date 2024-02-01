// See https://aka.ms/new-console-template for more information

using IteratorPattern;
using IteratorPattern.Spotify;

// Console.WriteLine("Hello, World!");
// var artist = new Artist("buiquochao", new List<Song>());

// var songs = new List<Song>(){
//     new("song1", artist),
//     new("song2", artist),
//     new("song3", artist),
//     new("song4", artist),
//     new("song5", artist),
// };
// var playlist = new Playlist(songs, true);

// IIterator<Song> iterator = playlist.CreateIterator();
// while (iterator.HasNext())
// {
//     Console.WriteLine(iterator.Next());
// }
// System.Console.WriteLine();
// iterator.Reset();
// while (iterator.HasNext())
// {
//     Console.WriteLine(iterator.Next());
// }

DemoCustomList demo = new DemoCustomList();
demo.DemoNext();