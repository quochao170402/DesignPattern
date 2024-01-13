// See https://aka.ms/new-console-template for more information
using AbstractFactory;
using AbstractFactory.Enums;
using AbstractFactory.Factories;
using AbstractFactory.Models;
using Type = AbstractFactory.Enums.Type;

const Type type = Type.Table;
const Style style = Style.Victorian;

IFactory factory = new Factory();
IFurnitureFactory furnitureFactory = factory.GetFurnitureFactory(style);
Furniture furniture = furnitureFactory.CreateFurniture(type);
furniture.Display();