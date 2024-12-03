using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the hyperbolic tangent of the specified angle.
    /// </summary>
    /// <param name="value">An angle, measured in radians.</param>
    /// <returns>The hyperbolic tangent of the specified angle.</returns>
    public static double Tanh(this double value)
    {
        return Math.Tanh(value);
    }
}
