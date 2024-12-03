using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the larger of two 32-bit signed integers.
    /// </summary>
    /// <param name="val1">The first of two 32-bit signed integers to compare.</param>
    /// <param name="val2">The second of two 32-bit signed integers to compare.</param>
    /// <returns>The larger of the two integers.</returns>
    public static int Max(this int val1, int val2)
    {
        return Math.Max(val1, val2);
    }
}
