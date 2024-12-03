using System;
using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    ///     Categorizes the specified Unicode character into one of the UnicodeCategory values.
    /// </summary>
    /// <param name="c">The Unicode character to categorize.</param>
    /// <returns>
    ///     A UnicodeCategory value that identifies the group to which the specified character belongs.
    /// </returns>
    public static UnicodeCategory GetUnicodeCategory(this Char c)
    {
        return Char.GetUnicodeCategory(c);
    }
}
