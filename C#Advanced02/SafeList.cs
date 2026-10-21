namespace C_Advanced02
{
    internal class SafeList<T>
    {
        private List<T> Items { set; get; }
        public SafeList()
        {
            Items = new List<T>();
        }

        public void AddItem(T item)
        {
            Items.Add(item);
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index < Items.Count)
                return Items[index];
            return default!;
        }
    }
}
