using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the absolute value of a double-precision floating-point number.
    /// </summary>
    /// <param name="value">The number to get the absolute value of.</param>
    /// <returns>A double-precision floating-point number, <c>x</c>, such that <c>0 ≤ x</c>.</returns>
    public static double Abs(this double value)
    {
        return Math.Abs(value);
    }
}
