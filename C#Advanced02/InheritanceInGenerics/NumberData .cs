namespace C_Advanced02.InheritanceInGenerics;

// Inheriting with a Specific Type
internal class NumberData : Data<int>
{
    public NumberData(int value) : base(value)
    {
    }
}
