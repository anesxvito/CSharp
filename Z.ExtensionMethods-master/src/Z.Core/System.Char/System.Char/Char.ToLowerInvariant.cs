using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of a Unicode character to its lowercase equivalent using the casing rules of the invariant culture.
    ///     The invariant culture is culture-insensitive and provides a consistent way to convert characters to lowercase.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>
    ///     The lowercase equivalent of the specified character, or the unchanged value if the character is already lowercase
    ///     or not alphabetic.
    /// </returns>
    public static Char ToLowerInvariant(this Char c)
    {
        return Char.ToLowerInvariant(c);
    }
}
