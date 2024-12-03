using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Unicode character is categorized as a punctuation mark.
    ///     This method checks if the character is classified as a punctuation mark according to the Unicode standard.
    ///     This includes characters like commas, periods, exclamation marks, etc.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>
    ///     <c>true</c> if the character is a punctuation mark (e.g., ',', '.', '!', '?');
    ///     otherwise, <c>false</c>.
    /// </returns>
    public static Boolean IsPunctuation(this Char c)
    {
        return Char.IsPunctuation(c);
    }
}
