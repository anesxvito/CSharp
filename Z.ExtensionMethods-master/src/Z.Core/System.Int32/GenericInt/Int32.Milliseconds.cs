using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int32 extension method that converts the given value to a TimeSpan in milliseconds.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A TimeSpan representing the given value in milliseconds.</returns>
    public static TimeSpan Milliseconds(this int @this)
    {
        return TimeSpan.FromMilliseconds(@this);
    }
}
