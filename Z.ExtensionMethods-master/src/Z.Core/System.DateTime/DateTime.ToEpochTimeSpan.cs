using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that converts the @this to an epoch time span.
    ///     The input DateTime is assumed to be in UTC. If not, convert it to UTC first.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a TimeSpan from Unix epoch (1970-01-01T00:00:00Z).</returns>
    public static TimeSpan ToEpochTimeSpan(this DateTime @this)
    {
        // Ensure the DateTime is in UTC for accurate calculation
        DateTime utcDateTime = @this.Kind == DateTimeKind.Utc ? @this : @this.ToUniversalTime();

        return utcDateTime.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc));
    }
}
