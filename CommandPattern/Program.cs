// See https://aka.ms/new-console-template for more information
using CommandPattern;

Console.WriteLine("Hello, World!");

Receiver receiver = new Fan();
Receiver tv = new TV();
Receiver washingMachine = new WashingMachine();
Receiver airConditioner = new AirConditioner();

System.Console.WriteLine("Before");
System.Console.WriteLine(receiver.State);
System.Console.WriteLine(tv.State);
System.Console.WriteLine(washingMachine.State);
System.Console.WriteLine(airConditioner.State);

Invoker invoker = new Invoker();

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

System.Console.WriteLine("After");
System.Console.WriteLine(receiver.State);
System.Console.WriteLine(tv.State);
System.Console.WriteLine(washingMachine.State);
System.Console.WriteLine(airConditioner.State);