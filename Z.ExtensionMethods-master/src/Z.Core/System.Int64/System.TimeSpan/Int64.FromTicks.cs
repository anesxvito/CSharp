using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a specified number of ticks to a <see cref="TimeSpan"/> object.
    /// </summary>
    /// <param name="value">The number of ticks that represent a time interval. A tick represents 100 nanoseconds.</param>
    /// <returns>A <see cref="TimeSpan"/> object that represents the specified number of ticks.</returns>
    /// <remarks>
    ///     A single tick is equivalent to 100 nanoseconds, or 1/10,000,000 of a second. 
    ///     This method creates a <see cref="TimeSpan"/> from the given number of ticks.
    /// </remarks>
    public static TimeSpan FromTicks(this Int64 value)
    {
        return TimeSpan.FromTicks(value);
    }
}
