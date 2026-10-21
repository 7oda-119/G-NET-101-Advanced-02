namespace C_Advanced02.InAndOut;

internal class VehicleProcessor : IProcessor<Vehical>
{
    public void Processs(Vehical item)
    {
        Console.WriteLine("Processing Vehicle");
    }
}
