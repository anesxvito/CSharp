using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int64 extension method that checks if the value is a multiple of a given factor.
    /// </summary>
    /// <param name="this">The value to check.</param>
    /// <param name="factor">The factor to check divisibility against.</param>
    /// <returns>true if the value is a multiple of the factor, false otherwise.</returns>
    public static bool IsMultipleOf(this long @this, long factor)
    {
        return @this % factor == 0;
    }
}
