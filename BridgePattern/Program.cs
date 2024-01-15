// See https://aka.ms/new-console-template for more information
using BridgePattern;

Console.WriteLine("Hello, World!");

var tv = new TV();
var remote = new BasicRemote(tv);
remote.Display();
remote.TogglePower();
remote.Display();