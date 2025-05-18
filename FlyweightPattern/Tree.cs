namespace FlyweightPattern;

public class Tree
{
    public int X { get; set; }
    public int Y { get; set; }
    public TreeType TreeType { get; set; }

    public void MoveTree(int x, int y)
    {
        X += x;
        Y += y;
    }
}

/// <summary>
///     TreeType is Flyweight
/// </summary>
public class TreeType
{
    public string Name { get; init; }
    public string Color { get; init; }
    public string Texture { get; init; }

    public override string ToString()
    {
        return $"{Name} - {Color} - {Texture}";
    }
}

public class TreeFactory
{
    private readonly List<TreeType> _treeTypes;

    public TreeFactory()
    {
        _treeTypes = new List<TreeType>();
    }

    public TreeType GetTreeType(string name, string color, string texture)
    {
        var treeType = _treeTypes.FirstOrDefault(x => x.Name == name
                                                      && x.Color == color
                                                      && x.Texture == texture);
        if (treeType != null) return treeType;

        treeType = new TreeType
        {
            Name = name,
            Color = color,
            Texture = texture
        };

        _treeTypes.Add(treeType);
        Console.WriteLine($"Create new tree type: {treeType}");
        return treeType;
    }
}

public class Forest
{
    private readonly TreeFactory _treeFactory;

    public Forest(TreeFactory treeFactory)
    {
        _treeFactory = treeFactory;
    }

    public List<Tree> Trees { get; set; } = new();

    public Tree PlantTree(int x, int y, string name, string color, string texture)
    {
        var tree = new Tree
        {
            X = x,
            Y = y,
            TreeType = _treeFactory.GetTreeType(name, color, texture)
        };
        Trees.Add(tree);
        return tree;
    }

    public void Draw()
    {
        Trees.ForEach(tree => Console.WriteLine($"Tree: {tree.TreeType} - {tree.X} - {tree.Y}"));
    }

    public void MoveTrees(int x, int y)
    {
        Trees.ForEach(tree => tree.MoveTree(x, y));
    }
}