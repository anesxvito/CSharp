using System;

public static partial class Extensions
{
    /// <summary>
    ///     A long extension method that converts the given value to a TimeSpan representing the specified number of seconds.
    /// </summary>
    /// <param name="this">The value to act on, representing seconds.</param>
    /// <returns>A TimeSpan representing the specified number of seconds.</returns>
    public static TimeSpan Seconds(this long @this)
    {
        return TimeSpan.FromSeconds(@this);
    }
}
