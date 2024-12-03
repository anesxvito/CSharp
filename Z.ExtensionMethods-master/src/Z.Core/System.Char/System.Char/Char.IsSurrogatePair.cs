using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the two specified Unicode characters form a valid surrogate pair.
    ///     A surrogate pair is a combination of a high surrogate and a low surrogate, used to represent
    ///     characters outside the Basic Multilingual Plane (BMP) in UTF-16 encoding.
    ///     The high surrogate must be in the range U+D800 to U+DBFF, and the low surrogate must be in the range U+DC00 to U+DFFF.
    /// </summary>
    /// <param name="highSurrogate">The character to evaluate as the high surrogate of a surrogate pair.</param>
    /// <param name="lowSurrogate">The character to evaluate as the low surrogate of a surrogate pair.</param>
    /// <returns>
    ///     true if the characters form a valid surrogate pair; otherwise, false.
    /// </returns>
    public static Boolean IsSurrogatePair(this Char highSurrogate, Char lowSurrogate)
    {
        return Char.IsSurrogatePair(highSurrogate, lowSurrogate);
    }
}
