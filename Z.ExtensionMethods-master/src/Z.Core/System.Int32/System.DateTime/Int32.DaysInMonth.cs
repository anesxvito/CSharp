using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the number of days in the specified month and year.
    /// </summary>
    /// <param name="year">The year.</param>
    /// <param name="month">The month (a number ranging from 1 to 12).</param>
    /// <returns>
    ///     The number of days in the specified month and year. For example, if month equals 2 for February, 
    ///     the return value is 28 or 29 depending on whether the year is a leap year.
    /// </returns>
    public static int DaysInMonth(this int year, int month)
    {
        return DateTime.DaysInMonth(year, month);
    }
}
