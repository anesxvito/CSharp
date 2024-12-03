using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    /// Removes all items from the collection that satisfy the specified predicate.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to remove items from.</param>
    /// <param name="predicate">A function to test each item for a condition.</param>
    public static void RemoveWhere<T>(this ICollection<T> collection, Func<T, bool> predicate)
    {
        var itemsToRemove = collection.Where(predicate).ToList();
        foreach (var item in itemsToRemove)
        {
            collection.Remove(item);
        }
    }
}
