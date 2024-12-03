using System;

public static class Extensions
{
    /// <summary>
    ///     An Int16 extension method that converts the value to a TimeSpan representing weeks.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A TimeSpan representing the given number of weeks.</returns>
    public static TimeSpan Weeks(this short @this)
    {
        return TimeSpan.FromDays(@this * 7);
    }
}
