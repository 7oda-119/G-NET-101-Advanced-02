using C_Advanced02.ClassConstrain;

namespace C_Advanced02.BaseClassConstrain;

internal class Manager <T> where T : Person
{
    public void DisplayInfo(T item)
    {
        item.Display();
    }
}
