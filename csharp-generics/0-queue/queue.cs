/// <summary>
/// Generic Queue class that can store items of any type
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Returns the Queue's type parameter
    /// </summary>
    /// <returns>The type of T</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}