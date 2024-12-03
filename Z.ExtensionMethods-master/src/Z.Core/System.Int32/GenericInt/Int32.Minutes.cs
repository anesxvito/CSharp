using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int32 extension method that converts the given value to a TimeSpan in minutes.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A TimeSpan representing the given value in minutes.</returns>
    public static TimeSpan Minutes(this int @this)
    {
        return TimeSpan.FromMinutes(@this);
    }
}
