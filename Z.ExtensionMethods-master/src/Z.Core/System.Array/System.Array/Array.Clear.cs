using System;

public static partial class Extensions
{
    /// <summary>
    /// Clears a range of elements in the specified array, setting them to their default value (e.g., zero, false, or null).
    /// </summary>
    /// <param name="array">The array whose elements need to be cleared.</param>
    /// <param name="index">The starting index of the range of elements to clear.</param>
    /// <param name="length">The number of elements to clear.</param>
    public static void Clear(this Array array, int index, int length)
    {
        Array.Clear(array, index, length);
    }
}
