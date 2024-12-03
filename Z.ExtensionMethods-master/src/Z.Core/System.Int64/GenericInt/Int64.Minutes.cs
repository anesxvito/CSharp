using System;

public static partial class Extensions
{
    /// <summary>
    ///     A long extension method that converts the given value to a TimeSpan representing the specified number of minutes.
    /// </summary>
    /// <param name="this">The value to act on, representing minutes.</param>
    /// <returns>A TimeSpan representing the specified number of minutes.</returns>
    public static TimeSpan Minutes(this long @this)
    {
        return TimeSpan.FromMinutes(@this);
    }
}
