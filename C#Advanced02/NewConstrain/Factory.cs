namespace C_Advanced02.NewConstrain;

internal class Factory<T> where T : new()
{
    public T CreateInstance()
    {
        return new T();
    }
}
