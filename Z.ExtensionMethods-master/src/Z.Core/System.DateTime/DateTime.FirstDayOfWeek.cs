using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that returns the first day of the week based on the given culture's start day of the week.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startDayOfWeek">The day to consider as the first day of the week (e.g., Sunday or Monday).</param>
    /// <returns>A DateTime representing the first day of the week.</returns>
    public static DateTime FirstDayOfWeek(this DateTime @this, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
    {
        int diff = @this.DayOfWeek - startDayOfWeek;
        
        // Adjust the diff to handle negative values properly (when the current day is before the start day of the week).
        if (diff < 0)
        {
            diff += 7;
        }

        return @this.AddDays(-diff).Date; // Sets the time to 00:00:00.000
    }
}
