using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the absolute value of a 64-bit signed integer.
    /// </summary>
    /// <param name="value">The number for which to obtain the absolute value. The value can be any 64-bit signed integer.</param>
    /// <returns>A 64-bit signed integer, x, such that x >= 0. The absolute value of the input number.</returns>
    public static long Abs(this long value)
    {
        return Math.Abs(value);
    }
}
