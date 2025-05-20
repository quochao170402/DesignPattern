using AbstractFactory.Models;

namespace AbstractFactory.FurnitureStores;

/// <summary>
/// Abstract factory provides an interface for creating families of related or dependent objects
/// without specifying their concrete classes
/// </summary>
public interface IFurnitureStore
{
    Furniture CreateChair();
    Furniture CreateSofa();
    Furniture CreateTable();
}