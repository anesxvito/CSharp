using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of a specified instance of <see cref="Decimal"/> to its equivalent binary representation.
    /// </summary>
    /// <param name="d">The <see cref="Decimal"/> value to convert.</param>
    /// <returns>A 32-bit signed integer array with four elements that contain the binary representation of <paramref name="d"/>.</returns>
    public static Int32[] GetBits(this Decimal d)
    {
        return Decimal.GetBits(d);
    }
}
