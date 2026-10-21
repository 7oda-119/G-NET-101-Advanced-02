namespace C_Advanced02.InheritanceInGenerics;
// Inheriting as a Generic Class
internal class Store<T> : Data<T>
{
    public Store(T value) : base(value)
    {
    }
}
