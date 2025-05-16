// See https://aka.ms/new-console-template for more information
using StrategyPattern;

Character king = new King();
king.SetWeaponBehavior(new SwordWeapon());

king.Fight();

king.SetWeaponBehavior(new KnifeWeapon());

king.Fight();

king.SetWeaponBehavior(new AxeWeapon());

king.Fight();