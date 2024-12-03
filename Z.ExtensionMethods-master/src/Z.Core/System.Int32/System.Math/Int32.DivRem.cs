using System;

public static partial class Extensions
{
    /// <summary>
    ///     An Int32 extension method that returns the quotient and remainder of the division.
    /// </summary>
    /// <param name="a">The numerator.</param>
    /// <param name="b">The denominator.</param>
    /// <param name="result">[out] The remainder of the division.</param>
    /// <returns>The quotient of the division.</returns>
    public static int DivRem(this int a, int b, out int result)
    {
        return Math.DivRem(a, b, out result);
    }
}
