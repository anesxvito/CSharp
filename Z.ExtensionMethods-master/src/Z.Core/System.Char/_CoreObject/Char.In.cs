using System;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method to determine whether the object is equal to any of the provided values.
    /// </summary>
    /// <param name="this">The object to be compared.</param>
    /// <param name="values">The list of values to compare with the object.</param>
    /// <returns>true if the values list contains the object, otherwise false.</returns>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    public static bool IsIn(this char @this, params char[] values)
    {
        return values.Contains(@this);
    }
}
