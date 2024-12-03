using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the current DateTimeOffset to the specified time zone using its system time zone ID.
    /// </summary>
    /// <param name="dateTimeOffset">The DateTimeOffset to convert.</param>
    /// <param name="destinationTimeZoneId">The identifier of the time zone to convert to.</param>
    /// <returns>A DateTimeOffset that represents the time in the destination time zone.</returns>
    public static DateTimeOffset ConvertTimeBySystemTimeZoneId(this DateTimeOffset dateTimeOffset, string destinationTimeZoneId)
    {
        return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTimeOffset, destinationTimeZoneId);
    }
}
