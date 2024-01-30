namespace CommandPattern;

public class Invoker
{
    private readonly Queue<ICommand> _commands;
    private readonly Queue<ICommand> _histories;

    public Invoker()
    {
        _commands = new Queue<ICommand>();
        _histories = new Queue<ICommand>();
    }

    public void Push(ICommand command)
    {
        _commands.Enqueue(command);
    }

    public void Execute()
    {
        if (_commands.Count > 0)
        {
            var command = _commands.Dequeue();
            _histories.Enqueue(command);
            Console.WriteLine($"Execute command {command.GetType()}");
            command.Execute();
        }
    }

    public void Undo()
    {
        if (_histories.Count > 0)
        {
            var command = _histories.Dequeue();
            Console.WriteLine("Command undo");
            command.Undo();
        }
        else
        {
            Console.WriteLine("Command cannot undo");
        }
    }

}
