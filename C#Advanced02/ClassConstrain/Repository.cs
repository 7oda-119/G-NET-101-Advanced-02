namespace C_Advanced02.ClassConstrain;

internal class Repository<T> where T : class
{
    private T Item { get; set; }

    public Repository(T item)
    {
        Item = item;
    }

    public void Display(T newItem)
    {
        Console.WriteLine(Item);
    }
}
