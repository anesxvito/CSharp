using System;

public static partial class Extensions
{
    /// <summary>
    ///     Subtracts one specified <see cref="Decimal"/> value from another.
    /// </summary>
    /// <param name="d1">The minuend, or the value from which another value is subtracted.</param>
    /// <param name="d2">The subtrahend, or the value to subtract from <paramref name="d1"/>.</param>
    /// <returns>The result of subtracting <paramref name="d2"/> from <paramref name="d1"/>.</returns>
    public static Decimal Subtract(this Decimal d1, Decimal d2)
    {
        return Decimal.Subtract(d1, d2);
    }
}
