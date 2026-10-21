namespace C_Advanced02.InAndOut
{
    internal class Car : Vehical
    {
        public Car(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Car is moveing");
        }
    }
}
