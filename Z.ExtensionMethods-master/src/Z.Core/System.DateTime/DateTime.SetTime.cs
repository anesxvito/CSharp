using System;

public static partial class Extensions
{
    /// <summary>
    ///     Sets the time of the current date with hour precision.
    /// </summary>
    /// <param name="current">The current date.</param>
    /// <param name="hour">The hour.</param>
    /// <returns>A DateTime with the specified hour and zeroed out minutes, seconds, and milliseconds.</returns>
    public static DateTime SetTime(this DateTime current, int hour)
    {
        return SetTime(current, hour, 0, 0, 0);
    }

    /// <summary>
    ///     Sets the time of the current date with minute precision.
    /// </summary>
    /// <param name="current">The current date.</param>
    /// <param name="hour">The hour.</param>
    /// <param name="minute">The minute.</param>
    /// <returns>A DateTime with the specified hour, minute, and zeroed out seconds and milliseconds.</returns>
    public static DateTime SetTime(this DateTime current, int hour, int minute)
    {
        return SetTime(current, hour, minute, 0, 0);
    }

    /// <summary>
    ///     Sets the time of the current date with second precision.
    /// </summary>
    /// <param name="current">The current date.</param>
    /// <param name="hour">The hour.</param>
    /// <param name="minute">The minute.</param>
    /// <param name="second">The second.</param>
    /// <returns>A DateTime with the specified hour, minute, second, and zeroed out milliseconds.</returns>
    public static DateTime SetTime(this DateTime current, int hour, int minute, int second)
    {
        return SetTime(current, hour, minute, second, 0);
    }

    /// <summary>
    ///     Sets the time of the current date with millisecond precision.
    /// </summary>
    /// <param name="current">The current date.</param>
    /// <param name="hour">The hour.</param>
    /// <param name="minute">The minute.</param>
    /// <param name="second">The second.</param>
    /// <param name="millisecond">The millisecond.</param>
    /// <returns>A DateTime with the specified hour, minute, second, and millisecond.</returns>
    public static DateTime SetTime(this DateTime current, int hour, int minute, int second, int millisecond)
    {
        return new DateTime(current.Year, current.Month, current.Day, hour, minute, second, millisecond);
    }
}
