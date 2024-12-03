using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a specified number of days, accurate to the nearest millisecond, to a <see cref="TimeSpan"/>.
    /// </summary>
    /// <param name="value">The number of days to convert to a <see cref="TimeSpan"/>.</param>
    /// <returns>A <see cref="TimeSpan"/> that represents the specified number of days.</returns>
    public static TimeSpan FromDays(this double value)
    {
        return TimeSpan.FromDays(value);
    }
}
