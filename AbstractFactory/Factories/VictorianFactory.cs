using AbstractFactory.Models;
using AbstractFactory.Models.Chair;
using AbstractFactory.Models.Sofa;
using AbstractFactory.Models.Table;
using Type = AbstractFactory.Enums.Type;

namespace AbstractFactory.Factories;

public class VictorianFactory : IFurnitureFactory
{

    public Furniture CreateFurniture(Type type)
    {
        switch (type)
        {
            case Type.Chair:
                return new VictorianChair();
            case Type.Sofa:
                return new VictorianSofa();
            case Type.Table:
                return new VictorianTable();
            default:
                throw new ArgumentNullException("Not found type");
        }
    }
}
