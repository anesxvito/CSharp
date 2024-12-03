using System;

public static partial class Extensions
{
    /// <summary>
    /// Reverses the sequence of elements in the entire one-dimensional array.
    /// </summary>
    /// <param name="array">The one-dimensional array to reverse.</param>
    public static void Reverse(this Array array)
    {
        Array.Reverse(array);
    }

    /// <summary>
    /// Reverses the sequence of elements in a specified range within the one-dimensional array.
    /// </summary>
    /// <param name="array">The one-dimensional array to reverse.</param>
    /// <param name="index">The zero-based starting index of the section to reverse.</param>
    /// <param name="length">The number of elements in the section to reverse.</param>
    public static void Reverse(this Array array, int index, int length)
    {
        Array.Reverse(array, index, length);
    }
}
