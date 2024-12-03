using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the result of multiplying the specified <see cref="Decimal"/> value by negative one.
    /// </summary>
    /// <param name="d">The <see cref="Decimal"/> value to negate.</param>
    /// <returns>A <see cref="Decimal"/> number with the value of <paramref name="d"/>, but the opposite sign, or zero if <paramref name="d"/> is zero.</returns>
    public static Decimal Negate(this Decimal d)
    {
        return Decimal.Negate(d);
    }
}
