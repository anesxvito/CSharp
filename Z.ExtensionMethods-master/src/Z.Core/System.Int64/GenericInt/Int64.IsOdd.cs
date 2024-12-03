using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int64 (long) extension method that checks if the value is odd.
    /// </summary>
    /// <param name="this">The value to check.</param>
    /// <returns>true if the value is odd, false otherwise.</returns>
    public static bool IsOdd(this long @this)
    {
        return @this % 2 != 0;
    }
}
