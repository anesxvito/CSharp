using System;

public static class Extensions
{
    /// <summary>
    ///     An Int32 extension method that queries if '@this' is odd.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if odd, false if not.</returns>
    public static bool IsOdd(this int @this)
    {
        return @this % 2 != 0;
    }
}
