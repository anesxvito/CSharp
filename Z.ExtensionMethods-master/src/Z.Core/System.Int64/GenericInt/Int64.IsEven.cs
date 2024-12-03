using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int64 extension method that checks if the value is even.
    /// </summary>
    /// <param name="this">The value to check.</param>
    /// <returns>true if the value is even, false if not.</returns>
    public static bool IsEven(this long @this)
    {
        return @this % 2 == 0;
    }
}
