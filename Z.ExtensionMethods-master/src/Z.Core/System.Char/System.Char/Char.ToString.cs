using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the specified Unicode character to its equivalent string representation.
    ///     This method is a wrapper around the built-in Char.ToString method, providing an extension point for the Char type.
    /// </summary>
    /// <param name="c">The Unicode character to convert.</param>
    /// <returns>The string representation of the value of the specified character.</returns>
    public static string ToString(this char c)
    {
        return char.ToString(c);
    }
}
