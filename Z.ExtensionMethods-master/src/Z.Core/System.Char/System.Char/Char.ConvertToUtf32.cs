using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the value of a UTF-16 encoded surrogate pair into a Unicode code point.
    /// </summary>
    /// <param name="highSurrogate">
    ///     A high surrogate code unit (ranging from U+D800 to U+DBFF). Represents the first part of a surrogate pair.
    /// </param>
    /// <param name="lowSurrogate">
    ///     A low surrogate code unit (ranging from U+DC00 to U+DFFF). Represents the second part of a surrogate pair.
    /// </param>
    /// <returns>
    ///     The 21-bit Unicode code point represented by the high and low surrogate parameters, or an exception if the 
    ///     surrogates do not form a valid UTF-16 pair.
    /// </returns>
    public static Int32 ConvertToUtf32(this Char highSurrogate, Char lowSurrogate)
    {
        return Char.ConvertToUtf32(highSurrogate, lowSurrogate);
    }
}
