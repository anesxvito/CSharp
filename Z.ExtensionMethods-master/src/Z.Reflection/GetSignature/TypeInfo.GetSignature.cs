﻿// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.Linq;
using System.Reflection;
using System.Text;

public static partial class Extensions
{
    /// <summary>A Type extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetSignature(this Type @this)
    {
        // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments>] [:] [Inherited Class] [Inherited Interface]
        var sb = new StringBuilder();

        // Variable
        bool hasInheritedClass = false;

        // Name
        sb.Append(@this.IsGenericType ? @this.Name.Substring(0, @this.Name.IndexOf('`')) : @this.Name);

        // GenericArguments
        if (@this.IsGenericType)
        {
            Type[] arguments = @this.GetGenericArguments();
            sb.Append("<");
            sb.Append(string.Join(", ", arguments.Select(x =>
            {
                Type[] constraints = x.GetGenericParameterConstraints();

                foreach (Type constraint in constraints)
                {
                    GenericParameterAttributes gpa = constraint.GenericParameterAttributes;
                    GenericParameterAttributes variance = gpa & GenericParameterAttributes.VarianceMask;

                    if (variance != GenericParameterAttributes.None)
                    {
                        sb.Append((variance & GenericParameterAttributes.Covariant) != 0 ? "in " : "out ");
                    }
                }

                return x.GetShortDeclaraction();
            })));
            sb.Append(">");
        }

        return sb.ToString();
    }
}