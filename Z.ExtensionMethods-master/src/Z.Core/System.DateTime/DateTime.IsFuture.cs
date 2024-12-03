using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that checks if the given DateTime is in the future.
    /// </summary>
    /// <param name="this">The DateTime to act on.</param>
    /// <returns>true if the DateTime is in the future, false if not.</returns>
    public static bool IsFuture(this DateTime @this)
    {
        return @this > DateTime.UtcNow; // Use UtcNow for consistent time comparison
    }
}
