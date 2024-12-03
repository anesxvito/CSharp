using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the current DateTimeOffset to the specified time zone.
    /// </summary>
    /// <param name="dateTimeOffset">The DateTimeOffset to convert.</param>
    /// <param name="destinationTimeZone">The time zone to convert the DateTimeOffset to.</param>
    /// <returns>A DateTimeOffset that represents the time in the destination time zone.</returns>
    public static DateTimeOffset ConvertTime(this DateTimeOffset dateTimeOffset, TimeZoneInfo destinationTimeZone)
    {
        return TimeZoneInfo.ConvertTime(dateTimeOffset, destinationTimeZone);
    }
}
