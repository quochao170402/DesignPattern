// See https://aka.ms/new-console-template for more information

using AbstractFactory.Enums;
using AbstractFactory.FurnitureStores;

IFurnitureStore store = new ArtDecoFurnitureStore();
var table = store.CreateTable();

table.Display();