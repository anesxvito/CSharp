using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the specified Windows file time to an equivalent UTC time.
    /// </summary>
    /// <param name="fileTime">A Windows file time expressed as the number of 100-nanosecond intervals since January 1, 1601 (UTC).</param>
    /// <returns>
    ///     A DateTime object that represents the UTC time equivalent of the date and time represented by the specified file time.
    /// </returns>
    public static DateTime FromFileTimeUtc(this long fileTime)
    {
        return DateTime.FromFileTimeUtc(fileTime);
    }
}
