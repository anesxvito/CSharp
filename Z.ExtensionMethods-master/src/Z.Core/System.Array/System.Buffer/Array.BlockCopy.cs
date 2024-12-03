using System;

public static partial class Extensions
{
    /// <summary>
    ///     Copies a specified number of bytes from a source array starting at a particular offset 
    ///     to a destination array starting at a particular offset.
    /// </summary>
    /// <param name="src">The source array to copy bytes from.</param>
    /// <param name="srcOffset">The zero-based byte offset in the source array.</param>
    /// <param name="dst">The destination array to copy bytes to.</param>
    /// <param name="dstOffset">The zero-based byte offset in the destination array.</param>
    /// <param name="count">The number of bytes to copy.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="src"/> or <paramref name="dst"/> is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown when <paramref name="srcOffset"/>, <paramref name="dstOffset"/>, or <paramref name="count"/> 
    ///     is less than zero, or when the specified range exceeds the bounds of the source or destination array.
    /// </exception>
    public static void BlockCopy(this Array src, int srcOffset, Array dst, int dstOffset, int count)
    {
        if (src == null)
            throw new ArgumentNullException(nameof(src), "Source array cannot be null.");
        if (dst == null)
            throw new ArgumentNullException(nameof(dst), "Destination array cannot be null.");
        if (srcOffset < 0 || dstOffset < 0 || count < 0)
            throw new ArgumentOutOfRangeException("Offsets and count must be non-negative.");
        if (srcOffset + count > Buffer.ByteLength(src))
            throw new ArgumentException("Source array does not have enough data for the specified offset and count.");
        if (dstOffset + count > Buffer.ByteLength(dst))
            throw new ArgumentException("Destination array does not have enough space for the specified offset and count.");

        Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
    }
}
