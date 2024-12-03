using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a 64-bit signed integer to an array of bytes.
    /// </summary>
    /// <param name="value">The 64-bit signed integer to convert.</param>
    /// <returns>An array of bytes representing the specified integer. The array has a length of 8 bytes.</returns>
    public static byte[] GetBytes(this long value)
    {
        return BitConverter.GetBytes(value);
    }
}
