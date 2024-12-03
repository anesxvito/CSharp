using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the larger of two double-precision floating-point numbers.
    /// </summary>
    /// <param name="val1">The first of two double-precision floating-point numbers to compare.</param>
    /// <param name="val2">The second of two double-precision floating-point numbers to compare.</param>
    /// <returns>
    ///     The larger of the two values. If both values are equal, the method returns either value.
    /// </returns>
    public static double Max(this double val1, double val2)
    {
        return Math.Max(val1, val2);
    }
}
