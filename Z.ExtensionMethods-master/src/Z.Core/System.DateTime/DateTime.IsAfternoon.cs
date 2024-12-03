using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that checks if the given time is in the afternoon (12:00 PM to 11:59 PM).
    /// </summary>
    /// <param name="this">The DateTime instance to act on.</param>
    /// <returns>true if the time is afternoon, false if not.</returns>
    public static bool IsAfternoon(this DateTime @this)
    {
        return @this.Hour >= 12; // Check if the hour is 12 or greater (afternoon)
    }
}
