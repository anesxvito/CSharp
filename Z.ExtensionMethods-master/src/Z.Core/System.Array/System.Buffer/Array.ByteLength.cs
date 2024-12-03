using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the number of bytes in the specified array.
    /// </summary>
    /// <param name="array">An array whose byte length is to be calculated.</param>
    /// <returns>The number of bytes in the array.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="array"/> is null.</exception>
    public static int ByteLength(this Array array)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        }

        return Buffer.ByteLength(array);
    }
}
