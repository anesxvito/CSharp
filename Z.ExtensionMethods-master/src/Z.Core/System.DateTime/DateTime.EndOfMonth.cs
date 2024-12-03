using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that returns the DateTime of the last day of the month with the time set to
    ///     "23:59:59.999". The last moment of the last day of the month. 
    ///     Use "DateTime2" column type in SQL to keep the precision.
    /// </summary>
    /// <param name="this">The DateTime to act on.</param>
    /// <returns>A DateTime of the last day of the month with the time set to "23:59:59.999".</returns>
    public static DateTime EndOfMonth(this DateTime @this)
    {
        // Using Date property to get the first day of the month, add one month and subtract a tick to get the last moment.
        return @this.AddMonths(1).Date.AddTicks(-1);
    }
}
