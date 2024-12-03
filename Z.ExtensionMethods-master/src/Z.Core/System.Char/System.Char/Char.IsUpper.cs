using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Unicode character is categorized as an uppercase letter.
    ///     Uppercase letters are those characters that are capitalized, such as 'A', 'B', 'C', etc.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>
    ///     true if the character is an uppercase letter; otherwise, false.
    /// </returns>
    public static Boolean IsUpper(this Char c)
    {
        return Char.IsUpper(c);
    }
}
