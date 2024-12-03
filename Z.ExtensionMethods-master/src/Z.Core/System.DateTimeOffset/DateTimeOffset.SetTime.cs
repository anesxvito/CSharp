using System;

public static partial class Extensions
{
    /// <summary>
    /// Sets the time of the current date with hour precision.
    /// </summary>
    public static DateTimeOffset SetTime(this DateTimeOffset current, int hour) =>
        SetTime(current, hour, 0, 0, 0);

    /// <summary>
    /// Sets the time of the current date with hour and minute precision.
    /// </summary>
    public static DateTimeOffset SetTime(this DateTimeOffset current, int hour, int minute) =>
        SetTime(current, hour, minute, 0, 0);

    /// <summary>
    /// Sets the time of the current date with hour, minute, and second precision.
    /// </summary>
    public static DateTimeOffset SetTime(this DateTimeOffset current, int hour, int minute, int second) =>
        SetTime(current, hour, minute, second, 0);

    /// <summary>
    /// Sets the time of the current date with full precision, including milliseconds.
    /// </summary>
    public static DateTimeOffset SetTime(this DateTimeOffset current, int hour, int minute, int second, int millisecond)
    {
        return new DateTime(current.Year, current.Month, current.Day, hour, minute, second, millisecond, current.Offset);
    }
}
