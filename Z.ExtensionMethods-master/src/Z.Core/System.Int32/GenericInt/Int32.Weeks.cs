using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int32 extension method that converts the given number of weeks to a TimeSpan.
    /// </summary>
    /// <param name="this">The @this to act on (number of weeks).</param>
    /// <returns>A TimeSpan representing the given number of weeks.</returns>
    public static TimeSpan Weeks(this int @this)
    {
        return TimeSpan.FromDays(@this * 7);
    }
}
