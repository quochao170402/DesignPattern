using AbstractFactory.Enums;

namespace AbstractFactory.Factories;

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
