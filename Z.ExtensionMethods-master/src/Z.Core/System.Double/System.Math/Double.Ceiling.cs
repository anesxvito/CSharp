using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the smallest integral value that is greater than or equal to the specified double-precision floating-point number.
    /// </summary>
    /// <param name="a">A double-precision floating-point number.</param>
    /// <returns>
    ///     The smallest integral value that is greater than or equal to <paramref name="a"/>.
    ///     If <paramref name="a"/> is already an integer, that value is returned. 
    ///     The method returns a <see cref="Double"/> representing the smallest integer greater than or equal to <paramref name="a"/>.
    /// </returns>
    public static double Ceiling(this double a)
    {
        return Math.Ceiling(a);
    }
}
