using AbstractFactory.Models;
using AbstractFactory.Models.Chair;
using AbstractFactory.Models.Sofa;
using AbstractFactory.Models.Table;
using Type = AbstractFactory.Enums.Type;

namespace AbstractFactory.Factories;

public class ArtDecoFactory : IFurnitureFactory
{
    public Furniture CreateFurniture(Type type)
    {
        switch (type)
        {
            case Type.Chair:
                return new ArtDecoChair();
            case Type.Sofa:
                return new ArtDecoSofa();
            case Type.Table:
                return new ArtDecoTable();
            default:
                throw new ArgumentNullException("Not found type");
        }
    }
}
