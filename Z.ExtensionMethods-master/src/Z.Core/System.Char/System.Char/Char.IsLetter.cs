using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Unicode character is categorized as a letter.
    ///     A letter is a character that is classified as a letter in the Unicode character set.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>
    ///     <c>true</c> if the character is a letter; otherwise, <c>false</c>.
    /// </returns>
    public static Boolean IsLetter(this Char c)
    {
        return Char.IsLetter(c);
    }
}
