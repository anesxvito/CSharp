using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    /// Merges all inner enumerables into a single enumerable.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerables.</typeparam>
    /// <param name="enumerables">The collection of inner enumerables to merge.</param>
    /// <returns>A single enumerable containing all elements from the inner enumerables.</returns>
    public static IEnumerable<T> MergeInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> enumerables)
    {
        return enumerables.SelectMany(inner => inner);
    }
}
