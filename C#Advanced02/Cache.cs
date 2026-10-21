namespace C_Advanced02;

internal class Cache<TKey, TValue>
{
    private Dictionary<TKey, TValue> items;
    public Cache()
    {
        items = new Dictionary<TKey, TValue>();
    }

    public void Add(TKey key, TValue value)
    {
        items[key] = value;
    }

    public TValue Get(TKey key)
    {
        if(items.ContainsKey(key))
            return items[key];
        return default!;
    }

    public bool Remove(TKey key)
    {
        return items.Remove(key);
    }

    public bool Contains(TKey key)
    {
        return items.ContainsKey(key);
    }

    public void Expired()
    {
        items.Clear();
    }

}
