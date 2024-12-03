using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that returns the last moment of the last day of the year.
    ///     The time is set to "23:59:59:999".
    ///     Use "DateTime2" column type in SQL to maintain the precision.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTime of the last day of the year with the time set to "23:59:59:999".</returns>
    public static DateTime EndOfYear(this DateTime @this)
    {
        // Get the last day of the year by creating a new DateTime object and setting the time to the last moment
        return new DateTime(@this.Year, 12, 31, 23, 59, 59, 999);
    }
}
