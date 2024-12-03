using System;

public static partial class Extensions
{
    /// <summary>
    ///     Assigns a specified value to a byte at a particular location in a specified array.
    /// </summary>
    /// <param name="array">The array in which the byte will be set.</param>
    /// <param name="index">The zero-based index of the byte to set.</param>
    /// <param name="value">The value to assign to the specified byte.</param>
    /// <exception cref="ArgumentNullException">Thrown if the <paramref name="array"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown if <paramref name="index"/> is less than 0 or greater than or equal to the byte length of the array.
    /// </exception>
    public static void SetByte(this Array array, int index, byte value)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }

        if (index < 0 || index >= Buffer.ByteLength(array))
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index must be within the bounds of the array.");
        }

        Buffer.SetByte(array, index, value);
    }
}
