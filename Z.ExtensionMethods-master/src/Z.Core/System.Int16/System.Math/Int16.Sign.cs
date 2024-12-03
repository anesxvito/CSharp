using System;

public static class Extensions
{
    /// <summary>
    ///     Returns a value indicating the sign of a 16-bit signed integer.
    /// </summary>
    /// <param name="value">A signed number.</param>
    /// <returns>
    ///     A number that indicates the sign of value: 
    ///     -1 if value is less than zero, 
    ///     0 if value is equal to zero, 
    ///     1 if value is greater than zero.
    /// </returns>
    public static int Sign(this short value)
    {
        return Math.Sign(value);
    }
}
