using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that checks if the date part (without time) is equal to another date.
    /// </summary>
    /// <param name="date">The date to act on.</param>
    /// <param name="dateToCompare">The date to compare against.</param>
    /// <returns>true if the date part is equal, false otherwise.</returns>
    public static bool IsDateEqual(this DateTime date, DateTime dateToCompare)
    {
        return date.Date == dateToCompare.Date; // Compare only the Date part
    }
}
