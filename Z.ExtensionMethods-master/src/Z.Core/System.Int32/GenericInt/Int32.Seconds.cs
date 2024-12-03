using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int32 extension method that converts the given value to a TimeSpan in seconds.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A TimeSpan representing the given value in seconds.</returns>
    public static TimeSpan Seconds(this int @this)
    {
        return TimeSpan.FromSeconds(@this);
    }
}
