using FlyweightPattern;

// var forest = new OldForest();
// forest.PlantTree(1, 2, "a", "red", "b");
// forest.PlantTree(2, 1, "b", "red", "b");
// forest.PlantTree(3, 3, "c", "blue", "c");
// forest.PlantTree(2, 4, "d", "red", "b");
// forest.PlantTree(1, 4, "a", "red", "c");
// forest.PlantTree(4, 5, "a", "red", "b");
// forest.PlantTree(1, 1, "a", "blue", "b");
// forest.PlantTree(5, 3, "a", "red", "b");
// forest.PlantTree(2, 2, "d", "green", "b");
// forest.PlantTree(0, 2, "d", "red", "d");

// System.Console.WriteLine("Before move");
// forest.Draw();
// System.Console.WriteLine("==================");
// forest.MoveTrees(3, 4);
// System.Console.WriteLine("After move");
// forest.Draw();


var forest = new Forest(new TreeFactory());
forest.PlantTree(1, 2, "a", "red", "b");
forest.PlantTree(2, 1, "a", "red", "b");
forest.PlantTree(3, 3, "a", "blue", "b");
forest.PlantTree(2, 4, "a", "red", "b");
forest.PlantTree(1, 4, "a", "red", "b");
forest.PlantTree(4, 5, "a", "red", "c");
forest.PlantTree(1, 1, "a", "blue", "b");
forest.PlantTree(5, 3, "a", "red", "b");
forest.PlantTree(2, 2, "a", "green", "b");
forest.PlantTree(0, 2, "a", "red", "b");

System.Console.WriteLine("Before move");
forest.Draw();
System.Console.WriteLine("==================");
forest.MoveTrees(3, 4);
System.Console.WriteLine("After move");
forest.Draw();
