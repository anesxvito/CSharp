using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Determines whether the collection is null or empty.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to check.</param>
    /// <returns>True if the collection is null or empty; otherwise, false.</returns>
    public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
    {
        return collection == null || collection.Count == 0;
    }
}
