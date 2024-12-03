using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Unicode character is categorized as a number.
    ///     This method checks if the character is classified as a number according to the Unicode standard.
    ///     This includes digit characters (0-9) and other numeric symbols.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>
    ///     <c>true</c> if the character is a number (e.g., digits, numeric symbols);
    ///     otherwise, <c>false</c>.
    /// </returns>
    public static Boolean IsNumber(this Char c)
    {
        return Char.IsNumber(c);
    }
}
