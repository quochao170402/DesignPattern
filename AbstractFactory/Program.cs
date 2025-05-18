// See https://aka.ms/new-console-template for more information

using AbstractFactory.Enums;
using AbstractFactory.Factories;
using Type = AbstractFactory.Enums.Type;

const Type type = Type.Sofa;
const Style style = Style.Victorian;

IFactory factory = new Factory();
var furnitureFactory = factory.GetFurnitureFactory(style);
var furniture = furnitureFactory.CreateFurniture(type);
furniture.Display();