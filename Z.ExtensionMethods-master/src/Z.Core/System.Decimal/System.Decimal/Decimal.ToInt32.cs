using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of the specified <see cref="Decimal"/> to the equivalent 32-bit signed integer.
    /// </summary>
    /// <param name="d">The <see cref="Decimal"/> value to convert.</param>
    /// <returns>A 32-bit signed integer equivalent to the value of <paramref name="d"/>.</returns>
    public static int ToInt32(this Decimal d)
    {
        return Decimal.ToInt32(d);
    }
}
