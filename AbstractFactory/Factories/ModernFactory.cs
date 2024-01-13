using AbstractFactory.Models;
using AbstractFactory.Models.Chair;
using AbstractFactory.Models.Sofa;
using AbstractFactory.Models.Table;
using Type = AbstractFactory.Enums.Type;

namespace AbstractFactory.Factories;

public class ModernFactory : IFurnitureFactory
{
    public Furniture CreateFurniture(Type type)
    {
        switch (type)
        {
            case Type.Chair:
                return new ModernChair();
            case Type.Sofa:
                return new ModernSofa();
            case Type.Table:
                return new ModernTable();
            default:
                throw new ArgumentNullException("Not found type");
        }
    }
}
