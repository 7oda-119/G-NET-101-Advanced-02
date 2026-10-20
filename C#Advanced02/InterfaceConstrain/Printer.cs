namespace C_Advanced02.InterfaceConstrain;

internal class Printer<T> where T : IPrentable
{
    public void PrintItem(T item)
    {
        item.Print();
    }
}
