using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of the specified <see cref="Decimal"/> to the equivalent 16-bit signed integer.
    /// </summary>
    /// <param name="value">The <see cref="Decimal"/> value to convert.</param>
    /// <returns>A 16-bit signed integer equivalent to <paramref name="value"/>.</returns>
    public static short ToInt16(this Decimal value)
    {
        return Decimal.ToInt16(value);
    }
}
