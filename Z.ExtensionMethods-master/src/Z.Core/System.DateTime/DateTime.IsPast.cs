using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that queries if '@this' is in the past (ignoring milliseconds).
    /// </summary>
    /// <param name="this">The DateTime to act on.</param>
    /// <returns>true if the value is in the past (ignoring milliseconds), false if not.</returns>
    public static bool IsPast(this DateTime @this)
    {
        // Compare the date and time up to seconds (ignoring milliseconds)
        return @this.Year < DateTime.Now.Year ||
               (@this.Year == DateTime.Now.Year && @this.Month < DateTime.Now.Month) ||
               (@this.Year == DateTime.Now.Year && @this.Month == DateTime.Now.Month && @this.Day < DateTime.Now.Day) ||
               (@this.Year == DateTime.Now.Year && @this.Month == DateTime.Now.Month && @this.Day == DateTime.Now.Day && @this.Hour < DateTime.Now.Hour) ||
               (@this.Year == DateTime.Now.Year && @this.Month == DateTime.Now.Month && @this.Day == DateTime.Now.Day && @this.Hour == DateTime.Now.Hour && @this.Minute < DateTime.Now.Minute) ||
               (@this.Year == DateTime.Now.Year && @this.Month == DateTime.Now.Month && @this.Day == DateTime.Now.Day && @this.Hour == DateTime.Now.Hour && @this.Minute == DateTime.Now.Minute && @this.Second < DateTime.Now.Second);
    }
}
