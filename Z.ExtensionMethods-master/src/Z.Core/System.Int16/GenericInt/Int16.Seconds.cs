using System;

public static class Extensions
{
    /// <summary>
    ///     An Int16 extension method that converts the value to a TimeSpan representing seconds.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A TimeSpan representing the given number of seconds.</returns>
    public static TimeSpan Seconds(this short @this)
    {
        return TimeSpan.FromSeconds(@this);
    }
}
