using System;

public static partial class Extensions
{
    /// <summary>
    ///     Calculates the integral part of a specified decimal number by discarding the fractional digits.
    /// </summary>
    /// <param name="d">The decimal number to truncate.</param>
    /// <returns>
    ///     The integral part of <paramref name="d"/>—that is, the number with any fractional digits discarded.
    /// </returns>
    public static Decimal Truncate(this Decimal d)
    {
        return Math.Truncate(d);
    }
}
