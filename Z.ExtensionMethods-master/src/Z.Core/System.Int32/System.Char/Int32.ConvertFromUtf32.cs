using System;

public static partial class Extensions
{
    /// <summary>
    ///     Converts the specified Unicode code point into a UTF-16 encoded string.
    /// </summary>
    /// <param name="utf32">A 21-bit Unicode code point.</param>
    /// <returns>
    ///     A string consisting of one character or a surrogate pair of characters equivalent to the code point specified by
    ///     the utf32 parameter.
    /// </returns>
    public static string ConvertFromUtf32(this int utf32)
    {
        return char.ConvertFromUtf32(utf32);
    }
}
