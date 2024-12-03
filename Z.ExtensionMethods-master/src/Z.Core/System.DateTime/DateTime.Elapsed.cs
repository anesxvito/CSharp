using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that calculates the elapsed time from the given datetime.
    /// </summary>
    /// <param name="datetime">The datetime to act on.</param>
    /// <returns>A TimeSpan representing the elapsed time.</returns>
    public static TimeSpan Elapsed(this DateTime datetime)
    {
        // Use DateTime.UtcNow for a more accurate and consistent time calculation, avoiding timezone issues.
        return DateTime.UtcNow - datetime.ToUniversalTime();
    }
}
