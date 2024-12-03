using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts a decimal value to a money format by rounding it to two decimal places.
    /// </summary>
    /// <param name="this">The decimal value to convert to money format.</param>
    /// <returns>The decimal value rounded to two decimal places, representing the money format.</returns>
    public static Decimal ToMoney(this Decimal @this)
    {
        return Math.Round(@this, 2);
    }
}
