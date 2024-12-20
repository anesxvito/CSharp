using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the sine of the specified angle.
    /// </summary>
    /// <param name="a">An angle, measured in radians.</param>
    /// <returns>The sine of the input angle.</returns>
    public static double Sin(this double a)
    {
        return Math.Sin(a);
    }
}
