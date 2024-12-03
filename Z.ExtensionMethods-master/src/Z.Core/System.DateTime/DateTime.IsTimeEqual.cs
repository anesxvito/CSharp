using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that queries if the 'time' is time equal, ignoring milliseconds.
    /// </summary>
    /// <param name="time">The time to act on.</param>
    /// <param name="timeToCompare">The Date/Time to compare.</param>
    /// <returns>true if the times are equal (ignoring milliseconds), false if not.</returns>
    public static bool IsTimeEqual(this DateTime time, DateTime timeToCompare)
    {
        // Compare up to the second (ignoring milliseconds)
        return time.Hour == timeToCompare.Hour &&
               time.Minute == timeToCompare.Minute &&
               time.Second == timeToCompare.Second;
    }
}
