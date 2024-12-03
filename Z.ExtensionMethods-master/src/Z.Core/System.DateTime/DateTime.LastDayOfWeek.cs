using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that gets the last day of the week (Sunday).
    /// </summary>
    /// <param name="this">The DateTime to act on.</param>
    /// <returns>A DateTime representing the last day of the week (Sunday).</returns>
    public static DateTime LastDayOfWeek(this DateTime @this)
    {
        // Calculate the last day of the week (Sunday).
        return new DateTime(@this.Year, @this.Month, @this.Day).AddDays(DayOfWeek.Sunday - @this.DayOfWeek);
    }
}
