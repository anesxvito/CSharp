using System;

public static partial class Extensions
{
    /// <summary>
    ///     Retrieves the byte at a specified location in a specified array.
    /// </summary>
    /// <param name="array">The array from which the byte will be retrieved.</param>
    /// <param name="index">The zero-based index of the byte to retrieve.</param>
    /// <returns>The byte at the specified location in the array.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the <paramref name="array"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown if <paramref name="index"/> is less than 0 or greater than or equal to the byte length of the array.
    /// </exception>
    public static byte GetByte(this Array array, int index)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }

        if (index < 0 || index >= Buffer.ByteLength(array))
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index must be within the bounds of the array.");
        }

        return Buffer.GetByte(array, index);
    }
}
