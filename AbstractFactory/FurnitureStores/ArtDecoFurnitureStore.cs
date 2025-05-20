using AbstractFactory.Models;
using AbstractFactory.Models.Chair;
using AbstractFactory.Models.Sofa;
using AbstractFactory.Models.Table;

namespace AbstractFactory.FurnitureStores;

public class ArtDecoFurnitureStore : IFurnitureStore
{
    public Furniture CreateChair()
    {
        return new ArtDecoChair();
    }

    public Furniture CreateSofa()
    {
        return new ArtDecoSofa();
    }

    public Furniture CreateTable()
    {
        return new ArtDecoTable();
    }
}