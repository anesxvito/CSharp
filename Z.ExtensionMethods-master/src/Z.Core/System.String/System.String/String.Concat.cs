| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;

public static partial class Extensions
{
    /// <summary>
    ///     Concatenates two strings.
    /// </summary>
    /// <param name="str0">The first string to concatenate.</param>
    /// <param name="str1">The second string to concatenate.</param>
    /// <returns>The concatenation of str0 and str1.</returns>
    public static String Concat(this String str0, String str1)
    {
        return String.Concat(str0, str1);
    }

    /// <summary>
    ///     Concatenates three strings.
    /// </summary>
    /// <param name="str0">The first string to concatenate.</param>
    /// <param name="str1">The second string to concatenate.</param>
    /// <param name="str2">The third string to concatenate.</param>
    /// <returns>The concatenation of str0, str1, and str2.</returns>
    public static String Concat(this String str0, String str1, String str2)
    {
        return String.Concat(str0, str1, str2);
    }

    /// <summary>
    ///     Concatenates four strings.
    /// </summary>
    /// <param name="str0">The first string to concatenate.</param>
    /// <param name="str1">The second string to concatenate.</param>
    /// <param name="str2">The third string to concatenate.</param>
    /// <param name="str3">The fourth string to concatenate.</param>
    /// <returns>The concatenation of str0, str1, str2, and str3.</returns>
    public static String Concat(this String str0, String str1, String str2, String str3)
    {
        return String.Concat(str0, str1, str2, str3);
    }
}
