using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a specified number of milliseconds to a <see cref="TimeSpan"/>.
    /// </summary>
    /// <param name="value">The number of milliseconds to convert to a <see cref="TimeSpan"/>.</param>
    /// <returns>A <see cref="TimeSpan"/> representing the specified number of milliseconds.</returns>
    public static TimeSpan FromMilliseconds(this double value)
    {
        return TimeSpan.FromMilliseconds(value);
    }
}
