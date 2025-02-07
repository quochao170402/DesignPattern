# Abstract Factory Pattern

The Abstract Factory Pattern is a creational design pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes. This pattern is particularly useful when the system needs to be independent of how its objects are created, composed, and represented.

## Key Concepts

- **Abstract Factory**: Declares an interface for creating abstract products.
- **Concrete Factory**: Implements the operations to create concrete product objects.
- **Abstract Product**: Declares an interface for a type of product object.
- **Concrete Product**: Defines a product object to be created by the corresponding concrete factory and implements the Abstract Product interface.
- **Client**: Uses only interfaces declared by Abstract Factory and Abstract Product classes.

## UML Diagram

```plaintext
+-------------------+          +-------------------+
| AbstractFactory   |<-------->| Client            |
|-------------------|          |-------------------|
| + createProductA()|          | - factory:        |
| + createProductB()|          |   AbstractFactory |
+-------------------+          +-------------------+
          ^                              |
          |                              |
+-------------------+          +-------------------+
| ConcreteFactory1  |          | AbstractProductA  |
|-------------------|          |-------------------|
| + createProductA()|          | + operationA()    |
| + createProductB()|          +-------------------+
+-------------------+                    ^
          ^                              |
          |                              |
+-------------------+          +-------------------+
| ConcreteFactory2  |          | ConcreteProductA1 |
|-------------------|          |-------------------|
| + createProductA()|          | + operationA()    |
| + createProductB()|          +-------------------+
+-------------------+                    ^
                                         |
                               +-------------------+
                               | ConcreteProductA2 |
                               |-------------------|
                               | + operationA()    |
                               +-------------------+
```

## Example

Here is an example of the Abstract Factory Pattern in Java:

```c#
// Abstract Products
public abstract class Furniture
{
    public string Name { get; set; }
    public int Price { get; set; }
    public Style Style { get; set; }
    public Type Type { get; set; }
    public abstract void Display();
}

public class Chair : Furniture
{
    public Chair()
    {
        Type = Enums.Type.Chair;
    }
    public override void Display()
    {
        System.Console.WriteLine($"Chair {Style.GetDisplayName()}");
    }
}

public class Sofa : Furniture
{
    public override void Display()
    {
        System.Console.WriteLine($"Sofa {Style.GetDisplayName()}");
    }
}

public class Table : Furniture
{
    public override void Display()
    {
        System.Console.WriteLine($"Table {Style.GetDisplayName()}");
    }
}

// Concrete of Chair
public class ArtDecoChair : Chair
{
    public ArtDecoChair()
    {
        Style = Style.ArtDeco;
    }
}

public class VictorianChair : Chair
{
    public VictorianChair() : base()
    {
        Style = Style.Victorian;
    }
}

...

// Concrete of Sofa
public class ArtDecoSofa : Sofa
{
    public override void Display()
    {
        System.Console.WriteLine($"Sofa {this.Style.GetDisplayName()}");
    }
}

...

// Concrete of Table
public class ArtDecoTable : Table
{
    public override void Display()
    {
        System.Console.WriteLine($"Table {this.Style.GetDisplayName()}");
    }
}

...


// Abstract Factory
public interface IFactory
{
    IFurnitureFactory GetFurnitureFactory(Style style);
}


public interface IFurnitureFactory
{
    Furniture CreateFurniture(Type type);
}

// Concrete Factories
public class Factory : IFactory
{
    public IFurnitureFactory GetFurnitureFactory(Style style)
    {
        switch (style)
        {
            case Style.ArtDeco:
                return new ArtDecoFactory();
            case Style.Victorian:
                return new VictorianFactory();
            case Style.Modern:
                return new ModernFactory();
            default:
                throw new ArgumentNullException("Not found style");
        }
    }
}

public class ArtDecoFactory : IFurnitureFactory
{
    public Furniture CreateFurniture(Type type)
    {
        switch (type)
        {
            case Type.Chair:
                return new ArtDecoChair();
            case Type.Sofa:
                return new ArtDecoSofa();
            case Type.Table:
                return new ArtDecoTable();
            default:
                throw new ArgumentNullException("Not found type");
        }
    }
}

public class ModernFactory : IFurnitureFactory
{
    public Furniture CreateFurniture(Type type)
    {
        switch (type)
        {
            case Type.Chair:
                return new ModernChair();
            case Type.Sofa:
                return new ModernSofa();
            case Type.Table:
                return new ModernTable();
            default:
                throw new ArgumentNullException("Not found type");
        }
    }
}


public class VictorianFactory : IFurnitureFactory
{

    public Furniture CreateFurniture(Type type)
    {
        switch (type)
        {
            case Type.Chair:
                return new VictorianChair();
            case Type.Sofa:
                return new VictorianSofa();
            case Type.Table:
                return new VictorianTable();
            default:
                throw new ArgumentNullException("Not found type");
        }
    }
}


// Program.cs

const Type type = Type.Sofa;
const Style style = Style.Victorian;

IFactory factory = new Factory();
IFurnitureFactory furnitureFactory = factory.GetFurnitureFactory(style);
Furniture furniture = furnitureFactory.CreateFurniture(type);
furniture.Display();

```

```plaintext
Output: Sofa Art Deco
```

## Benefits

- **Isolation of concrete classes**: The Abstract Factory Pattern helps to isolate the client code from the concrete classes.
- **Ease of exchanging product families**: The pattern makes it easy to exchange entire product families without changing the client code.
- **Consistency among products**: It ensures that products created by a factory are compatible with each other.

## Drawbacks

- **Complexity**: The pattern can introduce complexity due to the increased number of classes and interfaces.
- **Difficulty in supporting new kinds of products**: Adding new products to the factory can be challenging as it requires changes to the abstract factory interface and all its concrete implementations.
