namespace C_Advanced02.InheritanceInGenerics;

internal class Data <T>
{
    public T Value { get; set; }
    public Data(T value)
    {
        Value = value;
    }

}
