using AbstractFactory.Models;
using AbstractFactory.Models.Chair;
using AbstractFactory.Models.Sofa;
using AbstractFactory.Models.Table;

namespace AbstractFactory.FurnitureStores;

public class VictorianFurnitureStore : IFurnitureStore
{
    public Furniture CreateChair()
    {
        return new VictorianChair();
    }

    public Furniture CreateSofa()
    {
        return new VictorianSofa();
    }

    public Furniture CreateTable()
    {
        return new VictorianTable();
    }
}