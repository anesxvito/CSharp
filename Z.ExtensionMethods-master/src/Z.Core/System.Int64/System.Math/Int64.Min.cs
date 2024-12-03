using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the smaller of two 64-bit signed integers.
    /// </summary>
    /// <param name="val1">The first of the two 64-bit signed integers to compare.</param>
    /// <param name="val2">The second of the two 64-bit signed integers to compare.</param>
    /// <returns>The smaller of the two integers. If the values are equal, returns the first parameter.</returns>
    public static long Min(this long val1, long val2)
    {
        return Math.Min(val1, val2);
    }
}
