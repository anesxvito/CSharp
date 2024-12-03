using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    /// Merges and returns a distinct set of elements from all inner enumerables within the collection.
    /// </summary>
    /// <typeparam name="T">The type of elements in the enumerables.</typeparam>
    /// <param name="enumerables">The collection of inner enumerables to merge.</param>
    /// <returns>An enumerable containing distinct elements from all inner enumerables.</returns>
    public static IEnumerable<T> MergeDistinctInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> enumerables)
    {
        return enumerables.SelectMany(inner => inner).Distinct();
    }
}
