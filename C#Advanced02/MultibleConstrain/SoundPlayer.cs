namespace C_Advanced02.MultibleConstrain;

internal class SoundPlayer<T> where T : class, ISound, new()
{
    public void Play()
    {
        T createObj = new T();
        createObj.MakeSound();
    }
}
