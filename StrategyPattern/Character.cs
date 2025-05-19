namespace StrategyPattern;

public class Character
{
    protected IWeaponBehavior? WeaponBehavior { get; private set; }
    protected IArmorBehavior? ArmorBehavior { get; private set; }
    public void SetWeaponBehavior(IWeaponBehavior behavior)
    {
        WeaponBehavior = behavior;
    }

    public void SetArmorBehavior(IArmorBehavior behavior)
    {
        ArmorBehavior = behavior;
    }

    public void Fight()
    {
        WeaponBehavior?.UseWeapon();
    }

    public void Wearing()
    {
        ArmorBehavior?.UseArmor();
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
