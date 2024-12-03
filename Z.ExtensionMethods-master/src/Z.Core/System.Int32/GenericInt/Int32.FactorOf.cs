using System;

public static class Extensions
{
    /// <summary>
    ///     An Int32 extension method that checks if the value is a factor of the given factor number.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="factorNumer">The factor number.</param>
    /// <returns>true if it succeeds, false if it fails.</returns>
    public static bool FactorOf(this int @this, int factorNumer)
    {
        return factorNumer % @this == 0;
    }
}
