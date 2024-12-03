using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the natural (base e) logarithm of a specified number.
    /// </summary>
    /// <param name="d">The number whose logarithm is to be found.</param>
    /// <returns>
    ///     The natural logarithm of <paramref name="d"/>. 
    ///     - If <paramref name="d"/> is positive, the result is the natural log (ln) of <paramref name="d"/>.
    ///     - If <paramref name="d"/> is zero or negative, the method returns NaN.
    /// </returns>
    public static double Log(this double d)
    {
        if (d <= 0)
        {
            return double.NaN; // Logarithm undefined for zero or negative numbers
        }
        return Math.Log(d);
    }

    /// <summary>
    ///     Returns the logarithm of a specified number in a specified base.
    /// </summary>
    /// <param name="d">The number whose logarithm is to be found.</param>
    /// <param name="newBase">The base of the logarithm.</param>
    /// <returns>
    ///     The logarithm of <paramref name="d"/> to the base <paramref name="newBase"/>.
    ///     - If <paramref name="d"/> is greater than zero, the method returns the log of <paramref name="d"/> to the base <paramref name="newBase"/>.
    ///     - If <paramref name="d"/> is zero or negative, the method returns NaN.
    ///     - If <paramref name="newBase"/> is 1 or less, the method returns NaN, as logarithms with base ≤ 1 are undefined.
    /// </returns>
    public static double Log(this double d, double newBase)
    {
        if (d <= 0 || newBase <= 1)
        {
            return double.NaN; // Logarithm undefined for zero, negative numbers, or base <= 1
        }
        return Math.Log(d, newBase);
    }
}
