using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of the specified <see cref="Decimal"/> to the equivalent 8-bit signed integer.
    /// </summary>
    /// <param name="value">The <see cref="Decimal"/> number to convert.</param>
    /// <returns>An 8-bit signed integer (<see cref="SByte"/>) equivalent to the value of <paramref name="value"/>.</returns>
    public static SByte ToSByte(this Decimal value)
    {
        return Decimal.ToSByte(value);
    }
}
