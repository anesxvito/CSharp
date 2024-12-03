using System;

public static partial class Extensions
{
    /// <summary>
    ///     A System.DateTime extension method that returns the end of the week for the given DateTime.
    /// </summary>
    /// <param name="dt">The DateTime to act on.</param>
    /// <param name="startDayOfWeek">(Optional) The start day of the week (default is Sunday).</param>
    /// <returns>A DateTime representing the last moment of the week.</returns>
    public static DateTime EndOfWeek(this DateTime dt, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
    {
        // Calculate the difference between the current day and the desired end of week day
        int daysUntilEndOfWeek = ((int)startDayOfWeek - (int)dt.DayOfWeek + 6) % 7;

        // Add the days difference to reach the end of the week
        DateTime endOfWeek = dt.AddDays(daysUntilEndOfWeek);

        // Return the DateTime for the end of the week with the time set to 23:59:59.999
        return new DateTime(endOfWeek.Year, endOfWeek.Month, endOfWeek.Day, 23, 59, 59, 999);
    }
}
