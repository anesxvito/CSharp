using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns an indication whether the specified year is a leap year.
    /// </summary>
    /// <param name="year">A 4-digit year.</param>
    /// <returns>true if the year is a leap year; otherwise, false.</returns>
    public static bool IsLeapYear(this int year)
    {
        return DateTime.IsLeapYear(year);
    }
}
