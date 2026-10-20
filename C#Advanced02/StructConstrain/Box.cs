namespace C_Advanced02.StructConstrain;

internal class Box<T> where T : struct
{
    private T Value { get; set; }

    public void AddItem(T value)
    {
        Value = value;
    }
}
