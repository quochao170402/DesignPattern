namespace StrategyPattern;

public interface IWeaponBehavior
{
    void UseWeapon();
}

public class SwordWeapon : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("Sword weapon");
    }
}

public class KnifeWeapon : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("Knife weapon");
    }
}

public class BowAndArrowWeapon : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("Bow and arrow weapon");
    }
}

public class AxeWeapon : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("Axe weapon");
    }
}