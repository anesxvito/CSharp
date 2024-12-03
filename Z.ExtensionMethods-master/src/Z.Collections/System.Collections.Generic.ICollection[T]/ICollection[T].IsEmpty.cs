using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Determines whether the collection is empty.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to check.</param>
    /// <returns>True if the collection is empty; otherwise, false.</returns>
    public static bool IsEmpty<T>(this ICollection<T> collection)
    {
        return collection.Count == 0;
    }
}
