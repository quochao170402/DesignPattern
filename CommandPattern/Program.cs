// See https://aka.ms/new-console-template for more information

using CommandPattern;
using CommandPattern.Commands;
using CommandPattern.Receivers;

Console.WriteLine("Hello, World!");
var invoker = new Invoker();
var ariConditioner = new AirConditioner();
invoker.Execute(new AirConditionerHighCommand(ariConditioner));
invoker.Execute(new AirConditionerHighCommand(ariConditioner));
invoker.Execute(new AirConditionerLowCommand(ariConditioner));
invoker.Execute(new AirConditionerHighCommand(ariConditioner));



var player = new MusicPlayer("Ngôi sao lẻ loi");
invoker.Execute(new MusicPlayerPlayCommand(player));
invoker.Execute(new MusicPlayerPauseCommand(player));

invoker.Undo();
invoker.Undo();
invoker.Undo();
invoker.Undo();
invoker.Undo();