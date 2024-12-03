using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int64 extension method that checks if the value is a factor of the given factor number.
    /// </summary>
    /// <param name="this">The value to act on.</param>
    /// <param name="factorNumer">The factor number.</param>
    /// <returns>true if the value is a factor of the given factor number, false if not.</returns>
    public static bool FactorOf(this long @this, long factorNumer)
    {
        return factorNumer % @this == 0;
    }
}
