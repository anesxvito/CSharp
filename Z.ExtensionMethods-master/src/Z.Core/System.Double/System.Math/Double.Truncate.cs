using System;

public static partial class Extensions
{
    /// <summary>
    ///     Calculates the integral part of a specified double-precision floating-point number.
    /// </summary>
    /// <param name="d">A number to truncate.</param>
    /// <returns>
    ///     The integral part of the specified number, which is the number that remains after any fractional digits have been discarded.
    /// </returns>
    public static double Truncate(this double d)
    {
        return Math.Truncate(d);
    }
}
