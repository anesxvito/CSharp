using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    /// Determines whether the enumerable is empty.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
    /// <param name="source">The enumerable to check.</param>
    /// <returns>True if the enumerable is empty; otherwise, false.</returns>
    public static bool IsEmpty<T>(this IEnumerable<T> source)
    {
        return !source.Any();
    }
}
