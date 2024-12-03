using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of the specified <see cref="Decimal"/> to the equivalent double-precision floating-point number.
    /// </summary>
    /// <param name="d">The <see cref="Decimal"/> value to convert.</param>
    /// <returns>A double-precision floating-point number equivalent to <paramref name="d"/>.</returns>
    public static double ToDouble(this Decimal d)
    {
        return Decimal.ToDouble(d);
    }
}
