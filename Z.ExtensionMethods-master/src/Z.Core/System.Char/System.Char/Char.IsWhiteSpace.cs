using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Unicode character is categorized as a white space character.
    ///     White space characters include spaces, tabs, line breaks, and other characters that are used for spacing in text.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>
    ///     true if the character is considered white space; otherwise, false.
    /// </returns>
    public static Boolean IsWhiteSpace(this Char c)
    {
        return Char.IsWhiteSpace(c);
    }
}
