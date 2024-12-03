using System;

public static partial class Extensions
{
    /// <summary>
    ///     A long extension method that converts the given value to a TimeSpan representing the specified number of milliseconds.
    /// </summary>
    /// <param name="this">The value to act on, representing milliseconds.</param>
    /// <returns>A TimeSpan representing the specified number of milliseconds.</returns>
    public static TimeSpan Milliseconds(this long @this)
    {
        return TimeSpan.FromMilliseconds(@this);
    }
}
