using System.Text;

namespace DecoratorPattern.InputStreamExample;

public interface IInputStream
{
    string Read();
}

public class FileInputStream : IInputStream
{
    public string Text { get; set; }

    public FileInputStream(string text)
    {
        Text = text;
    }

    public string Read()
    {
        return Text;
    }
}

#region Decorators

public abstract class FilterInputStream : IInputStream
{
    public IInputStream _inputStream;

    protected FilterInputStream(IInputStream inputStream)
    {
        _inputStream = inputStream;
    }

    public abstract string Read();
}

public class LowerCaseInputStream : FilterInputStream
{
    public LowerCaseInputStream(IInputStream inputStream) : base(inputStream)
    {
    }

    public override string Read()
    {
        return _inputStream.Read().ToLower();
    }
}

public class BufferedInputStream : FilterInputStream
{
    public BufferedInputStream(IInputStream inputStream) : base(inputStream)
    {
    }

    public override string Read()
    {
        var text = _inputStream.Read();

        var stringBuilder = new StringBuilder();

        foreach (var c in text) stringBuilder.Append($"{c}_");

        return stringBuilder.ToString();
    }
}

#endregion