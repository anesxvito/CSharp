using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Unicode character is a low surrogate.
    ///     A low surrogate is a Unicode code unit in the range U+DC00 to U+DFFF, used in a surrogate pair.
    /// </summary>
    /// <param name="c">The character to evaluate.</param>
    /// <returns>
    ///     <c>true</c> if the character is a low surrogate (i.e., its numeric value ranges from U+DC00 to U+DFFF);
    ///     otherwise, <c>false</c>.
    /// </returns>
    public static Boolean IsLowSurrogate(this Char c)
    {
        return Char.IsLowSurrogate(c);
    }
}
