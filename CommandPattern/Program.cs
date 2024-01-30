// See https://aka.ms/new-console-template for more information
using CommandPattern;

Console.WriteLine("Hello, World!");

Receiver receiver = new Fan();
Invoker invoker = new Invoker(new Command(receiver));
invoker.Execute();
invoker.Undo();
invoker.Execute();
invoker.Execute();
invoker.Execute();