using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns a value indicating the sign of a 32-bit signed integer.
    /// </summary>
    /// <param name="value">A signed number.</param>
    /// <returns>
    ///     A number that indicates the sign of the value: 
    ///     -1 if the value is less than zero, 
    ///     0 if the value is equal to zero, 
    ///     1 if the value is greater than zero.
    /// </returns>
    public static int Sign(this int value)
    {
        return Math.Sign(value);
    }
}
