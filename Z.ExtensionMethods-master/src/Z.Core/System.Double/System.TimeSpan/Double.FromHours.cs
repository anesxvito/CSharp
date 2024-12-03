using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a specified number of hours, accurate to the nearest millisecond, to a <see cref="TimeSpan"/>.
    /// </summary>
    /// <param name="value">The number of hours to convert to a <see cref="TimeSpan"/>.</param>
    /// <returns>A <see cref="TimeSpan"/> that represents the specified number of hours.</returns>
    public static TimeSpan FromHours(this double value)
    {
        return TimeSpan.FromHours(value);
    }
}
