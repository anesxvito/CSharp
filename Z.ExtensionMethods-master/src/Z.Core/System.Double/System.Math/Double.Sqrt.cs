using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the square root of a specified number.
    /// </summary>
    /// <param name="d">The number whose square root is to be found.</param>
    /// <returns>The positive square root of the specified number. Returns NaN if the number is negative.</returns>
    public static double Sqrt(this double d)
    {
        return Math.Sqrt(d);
    }
}
