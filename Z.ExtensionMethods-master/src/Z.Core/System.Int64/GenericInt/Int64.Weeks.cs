using System;

public static partial class Extensions
{
    /// <summary>
    ///     A long extension method that converts the given value to a TimeSpan representing the specified number of weeks.
    /// </summary>
    /// <param name="this">The number of weeks.</param>
    /// <returns>A TimeSpan representing the specified number of weeks.</returns>
    public static TimeSpan Weeks(this long @this)
    {
        return TimeSpan.FromDays(@this * 7);
    }
}
