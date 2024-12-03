using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the current value is a factor of the specified factor.
    /// </summary>
    /// <param name="value">The current value to check.</param>
    /// <param name="factor">The factor to check against.</param>
    /// <returns>true if the current value is a factor of the specified factor, otherwise false.</returns>
    public static bool IsFactorOf(this Int16 value, Int16 factor)
    {
        return factor % value == 0;
    }
}
