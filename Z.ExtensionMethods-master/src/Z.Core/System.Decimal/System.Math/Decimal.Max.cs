using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the larger of two decimal numbers.
    /// </summary>
    /// <param name="val1">The first decimal number to compare.</param>
    /// <param name="val2">The second decimal number to compare.</param>
    /// <returns>
    ///     The larger of the two <paramref name="val1"/> and <paramref name="val2"/> values.
    /// </returns>
    public static Decimal Max(this Decimal val1, Decimal val2)
    {
        return Math.Max(val1, val2);
    }
}
