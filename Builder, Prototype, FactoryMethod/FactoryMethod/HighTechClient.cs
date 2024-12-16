using FactoryMethod.Abstract;
using FactoryMethod.HighTech;

namespace FactoryMethod;

public class HighTechClient: Client
{
    protected override IBench CreateBench()
    {
        return new HighTechBench();
    }

    protected override ICouch CreateCouch()
    {
        return new HighTechCouch();
    }

    protected override IChair CreateChair()
    {
        return new HighTechChair();
    }

    protected override ISofa CreateSofa()
    {
        return new HighTechSofa();
    }
}