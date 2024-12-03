using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the absolute value of a 32-bit signed integer.
    /// </summary>
    /// <param name="value">A number that is greater than or equal to zero, but less than or equal to Int32.MaxValue.</param>
    /// <returns>A 32-bit signed integer, x, such that 0 <= x <= Int32.MaxValue.</returns>
    public static int Abs(this int value)
    {
        return Math.Abs(value);
    }
}
