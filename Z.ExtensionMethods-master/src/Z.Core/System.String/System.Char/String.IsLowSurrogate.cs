| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;

public static partial class Extensions
{
    /// <summary>
    ///     Indicates whether the  object at the specified position in a string is a low surrogate.
    /// </summary>
    /// <param name="s">A string.</param>
    /// <param name="index">The position of the character to evaluate in .</param>
    /// <returns>
    ///     true if the numeric value of the specified character in the  parameter ranges from U+DC00 through U+DFFF;
    ///     otherwise, false.
    /// </returns>
    public static Boolean IsLowSurrogate(this String s, Int32 index)
    {
        return Char.IsLowSurrogate(s, index);
    }
}