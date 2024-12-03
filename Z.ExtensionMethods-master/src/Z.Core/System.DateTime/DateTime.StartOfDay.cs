using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that returns a DateTime with the time set to "00:00:00.000". The first moment of the day.
    /// </summary>
    /// <param name="this">The DateTime to act on.</param>
    /// <returns>A DateTime representing the first moment of the day, with the time set to "00:00:00.000".</returns>
    public static DateTime StartOfDay(this DateTime @this)
    {
        return new DateTime(@this.Year, @this.Month, @this.Day, 0, 0, 0, 0);
    }
}
