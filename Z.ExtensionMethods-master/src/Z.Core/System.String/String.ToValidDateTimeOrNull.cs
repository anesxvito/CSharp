// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    /// A string extension method that converts the @this to a valid date time or null.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a DateTime?</returns>
    public static DateTime? ToValidDateTimeOrNull(this string @this)
    {
        DateTime date;

        if (DateTime.TryParse(@this, out date))
        {
            return date;
        }

        return null;
    }
}