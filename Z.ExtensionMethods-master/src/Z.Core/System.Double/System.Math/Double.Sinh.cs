using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the hyperbolic sine of the specified angle.
    /// </summary>
    /// <param name="value">An angle, measured in radians.</param>
    /// <returns>The hyperbolic sine of the input angle.</returns>
    public static double Sinh(this double value)
    {
        return Math.Sinh(value);
    }
}
