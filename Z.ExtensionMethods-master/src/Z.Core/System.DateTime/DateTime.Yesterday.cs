using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that returns the date of yesterday at the same time.
    /// </summary>
    /// <param name="this">The current DateTime instance.</param>
    /// <returns>The DateTime of yesterday at the same time.</returns>
    public static DateTime Yesterday(this DateTime @this)
    {
        return @this.AddDays(-1);
    }
}
