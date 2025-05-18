// See https://aka.ms/new-console-template for more information

using CommandPattern;
using CommandPattern.Receivers;

Console.WriteLine("Hello, World!");

Receiver receiver = new Fan();
Receiver tv = new TV();
Receiver washingMachine = new WashingMachine();
Receiver airConditioner = new AirConditioner();

Console.WriteLine("Before");
Console.WriteLine(receiver.State);
Console.WriteLine(tv.State);
Console.WriteLine(washingMachine.State);
Console.WriteLine(airConditioner.State);

var invoker = new Invoker();

invoker.Push(new Command(receiver));
invoker.Push(new Command(tv));
invoker.Push(new Command(washingMachine));
invoker.Push(new Command(airConditioner));

invoker.Execute();
invoker.Execute();
invoker.Execute();
invoker.Execute();
invoker.Undo();
invoker.Undo();

Console.WriteLine("After");
Console.WriteLine(receiver.State);
Console.WriteLine(tv.State);
Console.WriteLine(washingMachine.State);
Console.WriteLine(airConditioner.State);