using System;

public static partial class Extensions
{
    /// <summary>
    ///     Divides the specified 64-bit signed integers and returns the quotient and remainder.
    /// </summary>
    /// <param name="a">The dividend (the number to be divided).</param>
    /// <param name="b">The divisor (the number by which to divide).</param>
    /// <param name="result">The remainder after dividing a by b. This is an output parameter.</param>
    /// <returns>The quotient after dividing a by b.</returns>
    public static long DivRem(this long a, long b, out long result)
    {
        return Math.DivRem(a, b, out result);
    }
}
