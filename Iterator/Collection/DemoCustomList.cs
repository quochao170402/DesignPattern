namespace IteratorPattern.Collection;

public class DemoCustomList
{
    public void DemoNext()
    {
        CustomList<string> list = new();
        list.Add("asdfadsf");
        list.Add("haha");
        list.Add("asdfaahahdsf");
        list.Add("aafhasdfadsf");
        list.Add("asdhafdhahfdfadsf");
        list.Add("asdffhahaadsf");

        var iterator = list.Iterator();

        Console.WriteLine("Next");
        while (iterator.HasNext()) Console.WriteLine(iterator.GetNext());

        Console.WriteLine("Previous");
        while (iterator.HasPrevious()) Console.WriteLine(iterator.GetPrevious());

        Console.WriteLine("Reset");
        iterator.Reset();

        Console.WriteLine("Next");
        while (iterator.HasNext()) Console.WriteLine(iterator.GetNext());

        Console.WriteLine("Previous");
        while (iterator.HasPrevious()) Console.WriteLine(iterator.GetPrevious());
    }
}