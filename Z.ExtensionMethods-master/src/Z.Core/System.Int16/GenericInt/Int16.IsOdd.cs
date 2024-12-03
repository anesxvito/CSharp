using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int16 extension method that queries if the value is odd.
    /// </summary>
    /// <param name="value">The value to act on.</param>
    /// <returns>true if the value is odd, false if not.</returns>
    public static bool IsOdd(this Int16 value)
    {
        return value % 2 != 0;
    }
}
