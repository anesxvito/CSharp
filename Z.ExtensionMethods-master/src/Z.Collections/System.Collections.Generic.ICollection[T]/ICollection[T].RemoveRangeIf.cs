using System;
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Removes a range of items from the collection if they satisfy the specified predicate.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to remove items from.</param>
    /// <param name="predicate">A function to test each item for a condition.</param>
    /// <param name="values">An array of items to evaluate and potentially remove.</param>
    public static void RemoveRangeIf<T>(this ICollection<T> collection, Func<T, bool> predicate, params T[] values)
    {
        foreach (var value in values)
        {
            if (predicate(value))
            {
                collection.Remove(value);
            }
        }
    }
}
