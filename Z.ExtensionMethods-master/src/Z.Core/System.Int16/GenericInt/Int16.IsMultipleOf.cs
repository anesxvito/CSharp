using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Int16 value is a multiple of the provided factor.
    /// </summary>
    /// <param name="value">The Int16 value to check.</param>
    /// <param name="factor">The factor to check against.</param>
    /// <returns>true if the value is a multiple of the factor; otherwise, false.</returns>
    public static bool IsMultipleOf(this Int16 value, Int16 factor)
    {
        return value % factor == 0;
    }
}
