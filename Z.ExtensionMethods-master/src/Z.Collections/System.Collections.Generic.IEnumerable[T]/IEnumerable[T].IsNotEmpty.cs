using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    /// Determines whether the enumerable is not empty.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
    /// <param name="source">The enumerable to check.</param>
    /// <returns>True if the enumerable is not empty; otherwise, false.</returns>
    public static bool IsNotEmpty<T>(this IEnumerable<T> source)
    {
        return source.Any();
    }
}
