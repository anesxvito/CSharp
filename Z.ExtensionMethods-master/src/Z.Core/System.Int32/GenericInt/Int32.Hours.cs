using System;

public static class Extensions
{
    /// <summary>
    ///     An Int32 extension method that converts the given value to a TimeSpan in hours.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A TimeSpan representing the number of hours.</returns>
    public static TimeSpan Hours(this int @this)
    {
        return TimeSpan.FromHours(@this);
    }
}
