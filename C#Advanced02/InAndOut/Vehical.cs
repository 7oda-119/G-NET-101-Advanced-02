namespace C_Advanced02.InAndOut
{
    internal class Vehical
    {
        public string Name { get; set; }
        public Vehical(string name)
        {
            Name = name;
        }

        public virtual void Move()
        {
            Console.WriteLine("Vehical is moveing");
        }

    }
}
