using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that returns a DateTime of the first day of the year with the time set to
    ///     "00:00:00:000". The first moment of the first day of the year.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DateTime of the first day of the year with the time set to "00:00:00:000".</returns>
    public static DateTime StartOfYear(this DateTime @this)
    {
        // Returns the first day of the year at midnight (00:00:00.000)
        return new DateTime(@this.Year, 1, 1);
    }
}
