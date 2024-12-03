using System;

public static partial class Extensions
{
    /// <summary>
    ///     Multiplies two specified <see cref="Decimal"/> values.
    /// </summary>
    /// <param name="d1">The multiplicand.</param>
    /// <param name="d2">The multiplier.</param>
    /// <returns>The result of multiplying <paramref name="d1"/> and <paramref name="d2"/>.</returns>
    public static Decimal Multiply(this Decimal d1, Decimal d2)
    {
        return Decimal.Multiply(d1, d2);
    }
}
