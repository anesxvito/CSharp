using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the absolute value of a specified <see cref="Decimal"/> number.
    /// </summary>
    /// <param name="value">The <see cref="Decimal"/> number to evaluate.</param>
    /// <returns>A <see cref="Decimal"/> that represents the absolute value of <paramref name="value"/>.</returns>
    public static Decimal Abs(this Decimal value)
    {
        return Math.Abs(value);
    }
}
