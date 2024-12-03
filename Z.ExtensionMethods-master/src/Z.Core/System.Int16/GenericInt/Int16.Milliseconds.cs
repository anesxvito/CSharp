using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the given Int16 value to a TimeSpan representing the number of milliseconds.
    /// </summary>
    /// <param name="value">The value to convert to a TimeSpan.</param>
    /// <returns>A TimeSpan representing the number of milliseconds.</returns>
    public static TimeSpan Milliseconds(this Int16 value)
    {
        return TimeSpan.FromMilliseconds(value);
    }
}
