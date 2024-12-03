using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the hyperbolic cosine of the specified angle.
    /// </summary>
    /// <param name="value">An angle, measured in radians.</param>
    /// <returns>
    ///     The hyperbolic cosine of <paramref name="value"/>.
    ///     If <paramref name="value"/> is equal to 0, the method returns 1.
    ///     If <paramref name="value"/> is infinite, the method returns Infinity.
    /// </returns>
    public static double Cosh(this double value)
    {
        return Math.Cosh(value);
    }
}
