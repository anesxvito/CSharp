// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System;
using System.Globalization;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that converts this object to an universal sortable long date time string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToUniversalSortableLongDateTimeString(this DateTime @this)
    {
        return @this.ToString("U", DateTimeFormatInfo.CurrentInfo);
    }

    /// <summary>
    ///     A DateTime extension method that converts this object to an universal sortable long date time string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToUniversalSortableLongDateTimeString(this DateTime @this, string culture)
    {
        return @this.ToString("U", new CultureInfo(culture));
    }

    /// <summary>
    ///     A DateTime extension method that converts this object to an universal sortable long date time string.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="culture">The culture.</param>
    /// <returns>The given data converted to a string.</returns>
    public static string ToUniversalSortableLongDateTimeString(this DateTime @this, CultureInfo culture)
    {
        return @this.ToString("U", culture);
    }
}