using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Unicode character is a high surrogate in a surrogate pair.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>
    ///     <c>true</c> if the character is a high surrogate (its numeric value ranges from U+D800 through U+DBFF); otherwise, <c>false</c>.
    /// </returns>
    public static Boolean IsHighSurrogate(this Char c)
    {
        return Char.IsHighSurrogate(c);
    }
}
