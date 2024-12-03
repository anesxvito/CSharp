| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns a String array containing the substrings in this string that are delied by elements of a specified
    ///     String array. A parameter specifies whether to return empty array elements.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="separator">A string that deli the substrings in this string.</param>
    /// <param name="option">
    ///     (Optional) Specify RemoveEmptyEntries to o empty array elements from the array returned,
    ///     or None to include empty array elements in the array returned.
    /// </param>
    /// <returns>
    ///     An array whose elements contain the substrings in this string that are delied by the separator.
    /// </returns>
    public static string[] Split(this string @this, string separator, StringSplitOptions option = StringSplitOptions.None)
    {
        return @this.Split(new[] {separator}, option);
    }
}