namespace StrategyPattern;

public interface IArmorBehavior
{
    void UseArmor();
}

public class LeatherArmor : IArmorBehavior
{
    public void UseArmor()
    {
        Console.WriteLine("Leather Armor");
    }
}

public class PlateArmor : IArmorBehavior
{
    public void UseArmor()
    {
        Console.WriteLine("Plate Armor");
    }
}

public class MagicRobes : IArmorBehavior
{
    public void UseArmor()
    {
        Console.WriteLine("Magic Robes");
    }
}
