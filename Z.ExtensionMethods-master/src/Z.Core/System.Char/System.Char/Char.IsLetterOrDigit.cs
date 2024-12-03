using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Unicode character is categorized as either a letter or a decimal digit.
    ///     A letter is any character that is classified as a letter, and a decimal digit is any character classified as a
    ///     digit in the Unicode character set.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>
    ///     <c>true</c> if the character is either a letter or a decimal digit; otherwise, <c>false</c>.
    /// </returns>
    public static Boolean IsLetterOrDigit(this Char c)
    {
        return Char.IsLetterOrDigit(c);
    }
}
