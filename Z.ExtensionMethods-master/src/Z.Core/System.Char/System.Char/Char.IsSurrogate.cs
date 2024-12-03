using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified character is a surrogate code unit.
    ///     A surrogate pair is a mechanism used to encode characters outside the Basic Multilingual Plane (BMP).
    ///     Surrogates are Unicode code units in the range U+D800 to U+DFFF.
    ///     This method checks if a character is part of such a surrogate pair, either as a high surrogate (U+D800 to U+DBFF) 
    ///     or a low surrogate (U+DC00 to U+DFFF).
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>true if the character is a high or low surrogate; otherwise, false.</returns>
    public static Boolean IsSurrogate(this Char c)
    {
        return Char.IsSurrogate(c);
    }
}
