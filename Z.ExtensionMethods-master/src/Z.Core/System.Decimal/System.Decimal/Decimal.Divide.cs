using System;

public static partial class Extensions
{
    /// <summary>
    ///     Divides two specified decimal values.
    /// </summary>
    /// <param name="d1">The dividend.</param>
    /// <param name="d2">The divisor.</param>
    /// <returns>The result of dividing <paramref name="d1"/> by <paramref name="d2"/>.</returns>
    /// <exception cref="DivideByZeroException">Thrown when <paramref name="d2"/> is zero.</exception>
    public static Decimal Divide(this Decimal d1, Decimal d2)
    {
        if (d2 == 0)
        {
            throw new DivideByZeroException("Divisor cannot be zero.");
        }
        return Decimal.Divide(d1, d2);
    }
}
