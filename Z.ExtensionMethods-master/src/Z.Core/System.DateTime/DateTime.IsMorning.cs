using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that checks if the given DateTime is in the morning (before 12:00 PM).
    /// </summary>
    /// <param name="this">The DateTime to act on.</param>
    /// <returns>true if the time is in the morning, false if not.</returns>
    public static bool IsMorning(this DateTime @this)
    {
        // Check if time is before noon (12:00 PM).
        return @this.Hour < 12;
    }
}
