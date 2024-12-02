﻿// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>A Type extension method that gets short declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The short declaraction.</returns>
    internal static string GetShortSignature(this Type @this)
    {
        if (@this == typeof (bool))
        {
            return "bool";
        }
        if (@this == typeof (byte))
        {
            return "byte";
        }
        if (@this == typeof (char))
        {
            return "char";
        }
        if (@this == typeof (decimal))
        {
            return "decimal";
        }
        if (@this == typeof (double))
        {
            return "double";
        }
        if (@this == typeof (Enum))
        {
            return "enum";
        }
        if (@this == typeof (float))
        {
            return "float";
        }
        if (@this == typeof (int))
        {
            return "int";
        }
        if (@this == typeof (long))
        {
            return "long";
        }
        if (@this == typeof (object))
        {
            return "object";
        }
        if (@this == typeof (sbyte))
        {
            return "sbyte";
        }
        if (@this == typeof (short))
        {
            return "short";
        }
        if (@this == typeof (string))
        {
            return "string";
        }
        if (@this == typeof (uint))
        {
            return "uint";
        }
        if (@this == typeof (ulong))
        {
            return "ulong";
        }
        if (@this == typeof (ushort))
        {
            return "ushort";
        }

        return @this.Name;
    }
}