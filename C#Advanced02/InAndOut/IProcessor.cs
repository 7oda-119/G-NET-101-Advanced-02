namespace C_Advanced02.InAndOut;

internal interface IProcessor<in T>
{
    void Processs(T item);
}
