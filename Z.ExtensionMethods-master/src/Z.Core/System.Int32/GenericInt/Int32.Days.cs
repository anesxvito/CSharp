using System;

public static class Extensions
{
    /// <summary>
    ///     An Int32 extension method that converts the given value to a TimeSpan in days.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A TimeSpan representing the number of days.</returns>
    public static TimeSpan Days(this int @this)
    {
        return TimeSpan.FromDays(@this);
    }
}
