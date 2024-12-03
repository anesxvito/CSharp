using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the cosine of the specified angle.
    /// </summary>
    /// <param name="d">An angle, measured in radians.</param>
    /// <returns>
    ///     The cosine of <paramref name="d"/>.
    ///     If <paramref name="d"/> is equal to 0, π/2, or multiples of π, the method returns the appropriate cosine value (1 for 0, 0 for π/2, and so on).
    /// </returns>
    public static double Cos(this double d)
    {
        return Math.Cos(d);
    }
}
