using System;

public static partial class Extensions
{
    /// <summary>
    ///     A long extension method that converts the given value to a TimeSpan representing hours.
    /// </summary>
    /// <param name="this">The value to act on.</param>
    /// <returns>A TimeSpan representing the given number of hours.</returns>
    public static TimeSpan Hours(this long @this)
    {
        return TimeSpan.FromHours(@this);
    }
}
