using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns e raised to the specified power.
    /// </summary>
    /// <param name="d">A number specifying the exponent.</param>
    /// <returns>
    ///     The number e (Euler's number) raised to the power of <paramref name="d"/>.
    ///     If <paramref name="d"/> is 0, the result is 1.
    ///     If <paramref name="d"/> is positive infinity, the result is positive infinity.
    ///     If <paramref name="d"/> is negative infinity, the result is 0.
    /// </returns>
    public static double Exp(this double d)
    {
        return Math.Exp(d);
    }
}
