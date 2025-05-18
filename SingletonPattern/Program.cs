// See https://aka.ms/new-console-template for more information

using SingletonPattern;

Console.WriteLine("Singleton design pattern");

for (var i = 0; i < 100; i++)
{
    var serverPool = ServerPool.GetInstance();
}