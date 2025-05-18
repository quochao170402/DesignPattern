namespace StrategyPattern;

public class Character
{
    protected IWeaponBehavior WeaponBehavior { get; private set; }

    public void SetWeaponBehavior(IWeaponBehavior behavior)
    {
        WeaponBehavior = behavior;
    }

    public void Fight()
    {
        WeaponBehavior.UseWeapon();
    }
}

public class King : Character
{
}

public class Queen : Character
{
}

public class Troll : Character
{
}