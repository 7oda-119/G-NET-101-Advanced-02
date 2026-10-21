namespace C_Advanced02.InAndOut;

internal interface IProducer <out T>
{
    T Get();
}
