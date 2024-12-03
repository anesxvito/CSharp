using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that returns a DateTime with the time set to "23:59:59.999", 
    ///     the last moment of the day. 
    ///     Use the "DateTime2" column type in SQL to keep the precision.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTime representing the last moment of the day, "23:59:59.999".</returns>
    public static DateTime EndOfDay(this DateTime @this)
    {
        // Using Date property to get the start of the day and adding one day, then subtracting a small time span
        return @this.Date.AddDays(1).AddTicks(-1);
    }
}
