using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that returns the start of the week, given a specified start day.
    /// </summary>
    /// <param name="dt">The DateTime to act on.</param>
    /// <param name="startDayOfWeek">The day of the week that defines the start of the week. Default is Sunday.</param>
    /// <returns>A DateTime representing the start of the week.</returns>
    public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
    {
        var start = new DateTime(dt.Year, dt.Month, dt.Day);
        int difference = start.DayOfWeek - startDayOfWeek;

        // If the startDayOfWeek is earlier in the week than the current day, adjust by subtracting the difference
        if (difference < 0)
        {
            difference += 7;
        }

        return start.AddDays(-difference).Date;
    }
}
