using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that checks if the current DateTime is the same as now (ignoring milliseconds).
    /// </summary>
    /// <param name="this">The DateTime to act on.</param>
    /// <returns>true if the DateTime is now (ignoring milliseconds), false if not.</returns>
    public static bool IsNow(this DateTime @this)
    {
        // Compare year, month, day, hour, minute, and second (ignore milliseconds)
        return @this.Year == DateTime.Now.Year &&
               @this.Month == DateTime.Now.Month &&
               @this.Day == DateTime.Now.Day &&
               @this.Hour == DateTime.Now.Hour &&
               @this.Minute == DateTime.Now.Minute &&
               @this.Second == DateTime.Now.Second;
    }
}
