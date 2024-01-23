// See https://aka.ms/new-console-template for more information
using System.Net;
using SingletonPattern;

Console.WriteLine("Singleton design pattern");

for (int i = 0; i < 100; i++)
{
    ServerPool serverPool = ServerPool.GetInstance();
}