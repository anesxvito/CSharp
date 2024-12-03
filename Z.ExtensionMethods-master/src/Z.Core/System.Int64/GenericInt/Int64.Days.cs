using System;

public static partial class Extensions
{
    /// <summary>
    ///     A long extension method that converts the given value to a TimeSpan representing days.
    /// </summary>
    /// <param name="this">The value to act on.</param>
    /// <returns>A TimeSpan representing the given number of days.</returns>
    public static TimeSpan Days(this long @this)
    {
        return TimeSpan.FromDays(@this);
    }
}
