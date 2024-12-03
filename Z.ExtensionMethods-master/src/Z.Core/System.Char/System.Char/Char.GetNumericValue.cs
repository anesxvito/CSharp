using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the specified Unicode character to its corresponding numeric value.
    ///     If the character is not a valid numeric character, returns -1.0.
    /// </summary>
    /// <param name="c">The Unicode character to convert to a numeric value.</param>
    /// <returns>
    ///     The numeric value of the character if it represents a number; otherwise, -1.0.
    /// </returns>
    public static Double GetNumericValue(this Char c)
    {
        return Char.GetNumericValue(c);
    }
}
