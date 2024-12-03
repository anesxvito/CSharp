using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the specified Windows file time to an equivalent local time.
    /// </summary>
    /// <param name="fileTime">A Windows file time expressed as the number of 100-nanosecond intervals since January 1, 1601 (UTC).</param>
    /// <returns>
    ///     A DateTime object that represents the local time equivalent of the date and time represented by the specified Windows file time.
    /// </returns>
    public static DateTime FromFileTime(this long fileTime)
    {
        return DateTime.FromFileTime(fileTime);
    }
}
