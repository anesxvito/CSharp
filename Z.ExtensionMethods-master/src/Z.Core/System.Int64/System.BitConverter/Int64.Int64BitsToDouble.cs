using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a 64-bit signed integer to a double-precision floating point number
    ///     by interpreting its bits as a double.
    /// </summary>
    /// <param name="value">The 64-bit signed integer to convert.</param>
    /// <returns>A double-precision floating point number whose value is represented by the bits of the given integer.</returns>
    public static double Int64BitsToDouble(this long value)
    {
        return BitConverter.Int64BitsToDouble(value);
    }
}
