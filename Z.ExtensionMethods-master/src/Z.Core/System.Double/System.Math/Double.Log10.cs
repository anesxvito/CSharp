using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the base 10 logarithm of a specified number.
    /// </summary>
    /// <param name="d">A number whose logarithm is to be found. The value must be greater than zero.</param>
    /// <returns>
    ///     The base 10 logarithm of <paramref name="d"/>.
    ///     - If <paramref name="d"/> is positive, the method returns the base 10 logarithm.
    ///     - If <paramref name="d"/> is zero or negative, the method returns NaN because the logarithm is undefined for non-positive numbers.
    /// </returns>
    public static double Log10(this double d)
    {
        if (d <= 0)
        {
            return double.NaN; // Logarithm undefined for zero or negative numbers
        }
        return Math.Log10(d);
    }
}
