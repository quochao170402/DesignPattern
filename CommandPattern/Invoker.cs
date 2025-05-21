using CommandPattern.Commands;

namespace CommandPattern;

public class Invoker
{
    private readonly Stack<ICommand> _histories;

    public Invoker()
    {
        _histories = new Stack<ICommand>();
    }

    public void Execute(ICommand command)
    {
        Console.WriteLine($"Execute command {command.GetType().Name}");
        command.Execute();
        _histories.Push(command);
    }


    public void Undo()
    {
        if (_histories.Count > 0)
        {
            var command = _histories.Pop();
            Console.WriteLine("Command undo");
            command.Undo();
        }
        else
        {
            Console.WriteLine("Histories is empty");
        }
    }
}