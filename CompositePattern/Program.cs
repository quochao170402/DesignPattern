using CompositePattern;

Console.WriteLine("Hello world");

Box box = new();
Box subBox = new();
subBox.AddProduct(new VideoGame() { Price = 20 });
subBox.AddProduct(new Phone() { Price = 200 });
subBox.AddProduct(new Book() { Price = 10 });

box.AddProduct(subBox);
box.AddProduct(new VideoGame() { Price = 1000 });

var price = box.GetPrice();
System.Console.WriteLine(price);

// IDeliveryBox     =   Component
// Box              =   Composite
// Product          =   Leaf 
// VideoGame        =   Leaf 
// Phone            =   Leaf 
// Book             =   Leaf 