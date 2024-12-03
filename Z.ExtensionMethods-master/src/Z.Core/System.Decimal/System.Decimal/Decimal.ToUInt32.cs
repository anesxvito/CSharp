using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of the specified <see cref="Decimal"/> to the equivalent 32-bit unsigned integer.
    /// </summary>
    /// <param name="d">The <see cref="Decimal"/> number to convert.</param>
    /// <returns>A <see cref="UInt32"/> equivalent to the value of <paramref name="d"/>.</returns>
    public static UInt32 ToUInt32(this Decimal d)
    {
        return Decimal.ToUInt32(d);
    }
}
