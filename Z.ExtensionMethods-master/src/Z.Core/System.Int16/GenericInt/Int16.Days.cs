using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int16 extension method that converts the given value to a TimeSpan representing that number of days.
    /// </summary>
    /// <param name="value">The number of days to convert to a TimeSpan.</param>
    /// <returns>A TimeSpan representing the given number of days.</returns>
    public static TimeSpan Days(this Int16 value)
    {
        return TimeSpan.FromDays(value);
    }
}
