using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Unicode character is categorized as a control character.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>
    ///     <c>true</c> if the character is a control character; otherwise, <c>false</c>.
    /// </returns>
    public static Boolean IsControl(this Char c)
    {
        return Char.IsControl(c);
    }
}
