using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Unicode character is categorized as a lowercase letter.
    ///     A lowercase letter is a letter that has a lowercase form (e.g., 'a' to 'z').
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>
    ///     <c>true</c> if the character is a lowercase letter; otherwise, <c>false</c>.
    /// </returns>
    public static Boolean IsLower(this Char c)
    {
        return Char.IsLower(c);
    }
}
