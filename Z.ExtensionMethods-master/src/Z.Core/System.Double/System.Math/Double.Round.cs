using System;

public static partial class Extensions
{
    /// <summary>
    ///     Rounds a double-precision floating-point value to the nearest integral value.
    /// </summary>
    /// <param name="a">A double-precision floating-point number to be rounded.</param>
    /// <returns>
    ///     The integer nearest to the input value. If the fractional component is halfway between two integers,
    ///     the even number is returned.
    /// </returns>
    public static double Round(this double a)
    {
        return Math.Round(a);
    }

    /// <summary>
    ///     Rounds a double-precision floating-point value to a specified number of fractional digits.
    /// </summary>
    /// <param name="a">A double-precision floating-point number to be rounded.</param>
    /// <param name="digits">The number of fractional digits in the return value.</param>
    /// <returns>The number nearest to the input value that contains the specified number of fractional digits.</returns>
    public static double Round(this double a, int digits)
    {
        return Math.Round(a, digits);
    }

    /// <summary>
    ///     Rounds a double-precision floating-point value to the nearest integer. Specifies how to round the value
    ///     if it is midway between two numbers.
    /// </summary>
    /// <param name="a">A double-precision floating-point number to be rounded.</param>
    /// <param name="mode">Specifies how to round if the value is midway between two other numbers.</param>
    /// <returns>
    ///     The integer nearest to the input value, with rounding behavior determined by the specified mode.
    /// </returns>
    public static double Round(this double a, MidpointRounding mode)
    {
        return Math.Round(a, mode);
    }

    /// <summary>
    ///     Rounds a double-precision floating-point value to a specified number of fractional digits. A parameter 
    ///     specifies how to round the value if it is midway between two numbers.
    /// </summary>
    /// <param name="a">A double-precision floating-point number to be rounded.</param>
    /// <param name="digits">The number of fractional digits in the return value.</param>
    /// <param name="mode">Specifies how to round if the value is midway between two other numbers.</param>
    /// <returns>
    ///     The number nearest to the input value, with the specified number of fractional digits and rounding behavior
    ///     determined by the specified mode.
    /// </returns>
    public static double Round(this double a, int digits, MidpointRounding mode)
    {
        return Math.Round(a, digits, mode);
    }
}
