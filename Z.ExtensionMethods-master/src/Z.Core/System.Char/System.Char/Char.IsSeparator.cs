using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Unicode character is categorized as a separator.
    ///     A separator character is one that separates words or phrases in a text. 
    ///     This includes spaces, tab characters, line breaks, and other whitespace characters.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>
    ///     <c>true</c> if the character is a separator, such as spaces, tabs, or newlines;
    ///     otherwise, <c>false</c>.
    /// </returns>
    public static Boolean IsSeparator(this Char c)
    {
        return Char.IsSeparator(c);
    }
}
