using System;
using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of a specified Unicode character to its lowercase equivalent using the specified culture's
    ///     casing rules.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <param name="culture">An object that supplies culture-specific casing rules.</param>
    /// <returns>
    ///     The lowercase equivalent of the character, modified according to the specified culture. 
    ///     If the character is already lowercase or not alphabetic, it will remain unchanged.
    /// </returns>
    public static Char ToLower(this Char c, CultureInfo culture)
    {
        return Char.ToLower(c, culture);
    }

    /// <summary>
    ///     Converts the value of a Unicode character to its lowercase equivalent using the default culture's casing rules.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>
    ///     The lowercase equivalent of the character, or the unchanged value if the character is already lowercase or not alphabetic.
    /// </returns>
    public static Char ToLower(this Char c)
    {
        return Char.ToLower(c);
    }
}
