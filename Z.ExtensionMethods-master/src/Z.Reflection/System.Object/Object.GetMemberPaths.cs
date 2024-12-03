| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Collections.Generic;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>A T extension method that gets member paths.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="path">Full pathname of the file.</param>
    /// <returns>An array of member information.</returns>
    public static MemberInfo[] GetMemberPaths<T>(this T @this, string path)
    {
        Type lastType = @this.GetType();
        string[] paths = path.Split('.');

        var memberPaths = new List<MemberInfo>();

        foreach (string item in paths)
        {
            PropertyInfo propertyInfo = lastType.GetProperty(item);
            FieldInfo fieldInfo = lastType.GetField(item);

            if (propertyInfo != null)
            {
                memberPaths.Add(propertyInfo);
                lastType = propertyInfo.PropertyType;
            }
            if (fieldInfo != null)
            {
                memberPaths.Add(fieldInfo);
                lastType = fieldInfo.FieldType;
            }
        }

        return memberPaths.ToArray();
    }
}