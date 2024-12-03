using System;

public static class Extensions
{
    /// <summary>
    ///     Returns the smaller of two 16-bit signed integers.
    /// </summary>
    /// <param name="val1">The first of two 16-bit signed integers to compare.</param>
    /// <param name="val2">The second of two 16-bit signed integers to compare.</param>
    /// <returns>The smaller of the two integers.</returns>
    public static short Min(this short val1, short val2)
    {
        return Math.Min(val1, val2);
    }
}
