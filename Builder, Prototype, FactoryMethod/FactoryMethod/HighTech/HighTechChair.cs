using FactoryMethod.Abstract;

namespace FactoryMethod.HighTech;

public class HighTechChair : IChair
{
    public override string ToString()
    {
        return "I'm a hightech chair";
    }
}