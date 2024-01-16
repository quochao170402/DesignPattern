using CompositePattern.Car;
Console.WriteLine("Hello world");

// Box box = new();
// Box subBox = new();
// subBox.AddProduct(new VideoGame() { Price = 20 });
// subBox.AddProduct(new Phone() { Price = 200 });
// subBox.AddProduct(new Book() { Price = 10 });

// box.AddProduct(subBox);
// box.AddProduct(new VideoGame() { Price = 1000 });

// var price = box.GetPrice();
// System.Console.WriteLine(price);

// IDeliveryBox     =   Component
// Box              =   Composite
// Product          =   Leaf 
// VideoGame        =   Leaf 
// Phone            =   Leaf 
// Book             =   Leaf 

var car = new CarComponent();
car.AddComponent(new Valve() { Price = 100 });
car.AddComponent(new Chip() { Price = 200 });
car.AddComponent(new Valve() { Price = 300 });
car.AddComponent(new Screen() { Price = 400 });

var subCar = new CarComponent();
subCar.AddComponent(new Chip() { Price = 1 });
subCar.AddComponent(new Valve() { Price = 32200 });
subCar.AddComponent(new Screen() { Price = 33 });

car.AddComponent(subCar);
car.AddComponent(subCar);
car.AddComponent(subCar);
System.Console.WriteLine(car.GetPrice());