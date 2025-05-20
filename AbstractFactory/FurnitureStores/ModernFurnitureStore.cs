using AbstractFactory.Models;
using AbstractFactory.Models.Chair;
using AbstractFactory.Models.Sofa;
using AbstractFactory.Models.Table;

namespace AbstractFactory.FurnitureStores;

public class ModernFurnitureStore : IFurnitureStore
{
    public Furniture CreateChair()
    {
        return new ModernChair();
    }

    public Furniture CreateSofa()
    {
        return new ModernSofa();
    }

    public Furniture CreateTable()
    {
        return new ModernTable();
    }
}