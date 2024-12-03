using System;

public static partial class Extensions
{
    /// <summary>
    ///     Computes the remainder after dividing two <see cref="Decimal"/> values.
    /// </summary>
    /// <param name="d1">The <see cref="Decimal"/> dividend.</param>
    /// <param name="d2">The <see cref="Decimal"/> divisor.</param>
    /// <returns>The remainder after dividing <paramref name="d1"/> by <paramref name="d2"/>.</returns>
    public static Decimal Remainder(this Decimal d1, Decimal d2)
    {
        return Decimal.Remainder(d1, d2);
    }
}
