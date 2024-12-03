using System;

public static partial class Extensions
{
    /// <summary>
    ///     Rounds a decimal value to the nearest integral value.
    /// </summary>
    /// <param name="d">A decimal number to be rounded.</param>
    /// <returns>
    ///     The integer nearest to <paramref name="d"/>. If the fractional component of <paramref name="d"/> is halfway
    ///     between two integers, the even number is returned (banker's rounding).
    /// </returns>
    public static Decimal Round(this Decimal d)
    {
        return Math.Round(d);
    }

    /// <summary>
    ///     Rounds a decimal value to a specified number of fractional digits.
    /// </summary>
    /// <param name="d">A decimal number to be rounded.</param>
    /// <param name="decimals">The number of decimal places in the return value.</param>
    /// <returns>
    ///     The number nearest to <paramref name="d"/> that contains a number of fractional digits equal to <paramref name="decimals"/>.
    /// </returns>
    public static Decimal Round(this Decimal d, Int32 decimals)
    {
        return Math.Round(d, decimals);
    }

    /// <summary>
    ///     Rounds a decimal value to the nearest integer. A parameter specifies how to round the value if it is midway
    ///     between two numbers.
    /// </summary>
    /// <param name="d">A decimal number to be rounded.</param>
    /// <param name="mode">The method used to round <paramref name="d"/> when it is exactly halfway between two other numbers.</param>
    /// <returns>
    ///     The integer nearest to <paramref name="d"/>. If <paramref name="d"/> is halfway between two numbers, one of which
    ///     is even and the other odd, <paramref name="mode"/> determines which of the two is returned.
    /// </returns>
    public static Decimal Round(this Decimal d, MidpointRounding mode)
    {
        return Math.Round(d, mode);
    }

    /// <summary>
    ///     Rounds a decimal value to a specified number of fractional digits. A parameter specifies how to round the
    ///     value if it is midway between two numbers.
    /// </summary>
    /// <param name="d">A decimal number to be rounded.</param>
    /// <param name="decimals">The number of decimal places in the return value.</param>
    /// <param name="mode">The method used to round <paramref name="d"/> when it is exactly halfway between two other numbers.</param>
    /// <returns>
    ///     The number nearest to <paramref name="d"/> that contains a number of fractional digits equal to <paramref name="decimals"/>.
    ///     If <paramref name="d"/> has fewer fractional digits than <paramref name="decimals"/>, <paramref name="d"/> is returned unchanged.
    /// </returns>
    public static Decimal Round(this Decimal d, Int32 decimals, MidpointRounding mode)
    {
        return Math.Round(d, decimals, mode);
    }
}
