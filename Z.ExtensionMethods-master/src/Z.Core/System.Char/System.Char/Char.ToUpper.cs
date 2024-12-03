using System;
using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    /// Converts the value of a specified Unicode character to its uppercase equivalent using specified culture-
    /// specific formatting information.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <param name="culture">An object that supplies culture-specific casing rules.</param>
    /// <returns>
    /// The uppercase equivalent of <paramref name="c"/>, modified according to <paramref name="culture"/>,
    /// or the unchanged value of <paramref name="c"/> if <paramref name="c"/> is already uppercase,
    /// has no uppercase equivalent, or is not alphabetic.
    /// </returns>
    public static Char ToUpper(this Char c, CultureInfo culture)
    {
        return Char.ToUpper(c, culture);
    }

    /// <summary>
    /// Converts the value of a Unicode character to its uppercase equivalent.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>
    /// The uppercase equivalent of <paramref name="c"/>, or the unchanged value of <paramref name="c"/> if
    /// <paramref name="c"/> is already uppercase, has no uppercase equivalent, or is not alphabetic.
    /// </returns>
    public static Char ToUpper(this Char c)
    {
        return Char.ToUpper(c);
    }
}
