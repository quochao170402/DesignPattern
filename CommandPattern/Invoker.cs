namespace CommandPattern;

public class Invoker
{
    private readonly ICommand _command;

    public Invoker(ICommand command)
    {
        _command = command;
    }

    public void Execute()
    {
        _command.Execute();
    }

    public void Undo()
    {
        _command.Undo();
    }

}
