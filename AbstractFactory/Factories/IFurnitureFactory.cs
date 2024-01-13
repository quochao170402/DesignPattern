using AbstractFactory.Models;
using Type = AbstractFactory.Enums.Type;

namespace AbstractFactory.Factories;

public interface IFurnitureFactory
{
    Furniture CreateFurniture(Type type);
}
