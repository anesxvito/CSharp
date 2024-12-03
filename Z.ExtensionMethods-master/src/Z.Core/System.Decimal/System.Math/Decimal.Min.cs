using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the smaller of two decimal numbers.
    /// </summary>
    /// <param name="val1">The first decimal number to compare.</param>
    /// <param name="val2">The second decimal number to compare.</param>
    /// <returns>
    ///     The smaller of the two <paramref name="val1"/> and <paramref name="val2"/> values.
    /// </returns>
    public static Decimal Min(this Decimal val1, Decimal val2)
    {
        return Math.Min(val1, val2);
    }
}
