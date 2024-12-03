using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Unicode character is categorized as a decimal digit.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>
    ///     <c>true</c> if the character is a decimal digit (0-9); otherwise, <c>false</c>.
    /// </returns>
    public static Boolean IsDigit(this Char c)
    {
        return Char.IsDigit(c);
    }
}
