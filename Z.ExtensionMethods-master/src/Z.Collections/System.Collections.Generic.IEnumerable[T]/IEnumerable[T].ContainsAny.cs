using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    /// Determines whether the enumerable contains any of the specified values.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
    /// <param name="source">The enumerable to act on.</param>
    /// <param name="values">An array of values to check for in the enumerable.</param>
    /// <returns>True if the enumerable contains any of the specified values; otherwise, false.</returns>
    public static bool ContainsAny<T>(this IEnumerable<T> source, params T[] values)
    {
        return values.Any(value => source.Contains(value));
    }
}
