namespace FlyweightPattern;
public class OldTree
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Texture { get; set; }

    public void MoveTree(int x, int y)
    {
        X += x;
        Y += y;
    }
}

public class OldForest
{
    public List<OldTree> Trees { get; set; } = new List<OldTree>();

    public OldTree PlantTree(int x, int y, string name, string color, string texture)
    {
        var tree = new OldTree
        {
            X = x,
            Y = y,
            Name = name,
            Color = color,
            Texture = texture
        };
        Trees.Add(tree);
        return tree;
    }

    public void Draw()
    {
        Trees.ForEach(tree => Console.WriteLine($"Tree: {tree.Name} - {tree.Color} - {tree.Texture} - {tree.X} - {tree.Y}"));
    }

    public void MoveTrees(int x, int y)
    {
        Trees.ForEach(tree => tree.MoveTree(x, y));
    }
}