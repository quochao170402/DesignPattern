// See https://aka.ms/new-console-template for more information

using IteratorPattern;

Console.WriteLine("Hello, World!");
var myPlaylist = new Playlist();
myPlaylist.AddSong(new Song("Title 1", "Artist 1"));
myPlaylist.AddSong(new Song("Title 2", "Artist 2"));
myPlaylist.AddSong(new Song("Title 3", "Artist 3"));
IIterator<Song> iterator = myPlaylist.CreateIterator();
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}