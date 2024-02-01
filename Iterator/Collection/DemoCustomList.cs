namespace IteratorPattern;

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

        IIterator<string> iterator = list.Iterator();

        System.Console.WriteLine("Next");
        while (iterator.HasNext())
        {
            System.Console.WriteLine(iterator.GetNext());
        }

        System.Console.WriteLine("Previous");
        while (iterator.HasPrevious())
        {
            System.Console.WriteLine(iterator.GetPrevious());
        }

        System.Console.WriteLine("Reset");
        iterator.Reset();

        System.Console.WriteLine("Next");
        while (iterator.HasNext())
        {
            System.Console.WriteLine(iterator.GetNext());
        }

        System.Console.WriteLine("Previous");
        while (iterator.HasPrevious())
        {
            System.Console.WriteLine(iterator.GetPrevious());
        }

    }
}
