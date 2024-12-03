using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of the specified <see cref="Decimal"/> to the equivalent single-precision floating-point number.
    /// </summary>
    /// <param name="d">The <see cref="Decimal"/> number to convert.</param>
    /// <returns>A <see cref="Single"/> equivalent to the value of <paramref name="d"/>.</returns>
    public static Single ToSingle(this Decimal d)
    {
        return Decimal.ToSingle(d);
    }
}
