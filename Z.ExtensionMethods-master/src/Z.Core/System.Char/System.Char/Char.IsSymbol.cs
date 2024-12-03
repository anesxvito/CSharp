using System;

public static partial class Extensions
{
    /// <summary>
    ///     Determines whether the specified Unicode character is categorized as a symbol character.
    ///     Symbol characters include mathematical symbols, currency symbols, and other types of symbols.
    /// </summary>
    /// <param name="c">The Unicode character to evaluate.</param>
    /// <returns>
    ///     true if the character is a symbol; otherwise, false.
    /// </returns>
    public static Boolean IsSymbol(this Char c)
    {
        return Char.IsSymbol(c);
    }
}
