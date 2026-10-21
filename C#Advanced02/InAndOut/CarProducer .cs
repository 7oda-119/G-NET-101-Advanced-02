namespace C_Advanced02.InAndOut;

internal class CarProducer : IProducer<Car>
{
    public Car Get()
    {
        return new Car("Tyota");
    }
}
