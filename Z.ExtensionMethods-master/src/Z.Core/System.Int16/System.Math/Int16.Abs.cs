using System;

public static class Extensions
{
    /// <summary>
    ///     Returns the absolute value of a 16-bit signed integer.
    /// </summary>
    /// <param name="value">A number that is greater than or equal to zero, but less than or equal to Int16.MaxValue.</param>
    /// <returns>A 16-bit signed integer, x, such that 0 <= x <= Int16.MaxValue.</returns>
    public static short Abs(this short value)
    {
        return Math.Abs(value);
    }
}
