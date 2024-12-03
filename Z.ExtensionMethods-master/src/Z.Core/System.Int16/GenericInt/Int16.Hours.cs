using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the specified number of hours (represented by this) into a TimeSpan.
    /// </summary>
    /// <param name="value">The number of hours to convert to a TimeSpan.</param>
    /// <returns>A TimeSpan that represents the specified number of hours.</returns>
    public static TimeSpan Hours(this Int16 value)
    {
        return TimeSpan.FromHours(value);
    }
}
