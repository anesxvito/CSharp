using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of the specified <see cref="Decimal"/> to the equivalent 8-bit unsigned integer.
    /// </summary>
    /// <param name="value">The <see cref="Decimal"/> value to convert.</param>
    /// <returns>An 8-bit unsigned integer equivalent to <paramref name="value"/>.</returns>
    public static byte ToByte(this Decimal value)
    {
        return Decimal.ToByte(value);
    }
}
