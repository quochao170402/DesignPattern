using AbstractFactory.Enums;

namespace AbstractFactory.Factories;

public interface IFactory
{
    IFurnitureFactory GetFurnitureFactory(Style style);
}