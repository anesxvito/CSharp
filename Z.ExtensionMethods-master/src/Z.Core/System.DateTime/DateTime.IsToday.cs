using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that checks if the date is today.
    /// </summary>
    /// <param name="this">The DateTime to act on.</param>
    /// <returns>true if the DateTime is today; otherwise, false.</returns>
    public static bool IsToday(this DateTime @this)
    {
        return @this.Date == DateTime.Today;
    }
}
