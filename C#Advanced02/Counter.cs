namespace C_Advanced02
{
    internal class Counter<T>
    {
        public static int count { get; set; } = 0;
        public Counter()
        {
            count++;
        }
    }
}
