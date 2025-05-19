// See https://aka.ms/new-console-template for more information

using StrategyPattern;

Character king = new King();
king.SetWeaponBehavior(new SwordWeapon());

king.Fight();
king.SetArmorBehavior(new MagicRobes());
king.Wearing();

king.SetWeaponBehavior(new KnifeWeapon());

king.Fight();

king.SetWeaponBehavior(new AxeWeapon());

king.Fight();

if (true)
{
    king.SetArmorBehavior(new PlateArmor());
    king.SetWeaponBehavior(new SwordWeapon());
}
