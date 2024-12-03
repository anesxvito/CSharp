using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of the specified <see cref="Decimal"/> to the equivalent 16-bit unsigned integer.
    /// </summary>
    /// <param name="value">The <see cref="Decimal"/> number to convert.</param>
    /// <returns>A <see cref="UInt16"/> equivalent to the value of <paramref name="value"/>.</returns>
    public static UInt16 ToUInt16(this Decimal value)
    {
        return Decimal.ToUInt16(value);
    }
}
