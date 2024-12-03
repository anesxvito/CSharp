using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the given Int16 value to a TimeSpan representing the number of minutes.
    /// </summary>
    /// <param name="value">The value to convert to a TimeSpan.</param>
    /// <returns>A TimeSpan representing the number of minutes.</returns>
    public static TimeSpan Minutes(this Int16 value)
    {
        return TimeSpan.FromMinutes(value);
    }
}
