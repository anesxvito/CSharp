using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns a value indicating the sign of a decimal number.
    /// </summary>
    /// <param name="value">A signed decimal number.</param>
    /// <returns>
    ///     A number that indicates the sign of <paramref name="value"/>:
    ///     -1 if <paramref name="value"/> is less than zero, 
    ///      0 if <paramref name="value"/> is equal to zero,
    ///      1 if <paramref name="value"/> is greater than zero.
    /// </returns>
    public static Int32 Sign(this Decimal value)
    {
        return Math.Sign(value);
    }
}
